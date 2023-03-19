using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Autobase
{
    public partial class WriteData : Form
    {
 
        public SqlDataAdapter dataAdapter = null;
        public WriteData()
        {
            InitializeComponent();
        }

        private void WriteData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.writeData". При необходимости она может быть перемещена или удалена.
            this.writeDataTableAdapter.Fill(this.autobaseDataSet.writeData);

        }

        private void changeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string journalID = GVwriteData.CurrentRow.Cells[0].Value.ToString();
            string driverId = GVwriteData.CurrentRow.Cells[11].Value.ToString();
            string carID = GVwriteData.CurrentRow.Cells[12].Value.ToString();
            string goodzID = GVwriteData.CurrentRow.Cells[14].Value.ToString();
            AddRecordF rec = new AddRecordF(journalID, _driverID: driverId, _carID: carID, _goodzID: goodzID);
            rec.Show();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.mainForm.Activate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecordF record;
            record = new AddRecordF(null, null, null, null);
            record.Show();
        }

        private void WriteData_Activated(object sender, EventArgs e)
        {
            this.writeDataTableAdapter.Fill(this.autobaseDataSet.writeData);
            if (dataAdapter != null)
                UpdateView("");
        }

        private void UpdateView(string filter)
        {
            string filter_name = "";
            /*if (filter == "owner")
            {
                filter_name = "WHERE Owner.Surname = '" + comboBox1.Text + "'";
            }
            else
            {
                if (filter == "guard")
                    filter_name = "WHERE Guard.Surname = '" + comboBox2.Text + "'";
                else
                    if (filter == "year")
                    filter_name = "WHERE Year(TimeArrival) = '" + comboBox3.Text + "'";
                else
                    if (filter == "month")
                    filter_name = "WHERE  Month(TimeArrival) = '" + comboBox4.Text + "'";
                else
                    if (filter == "day")
                    filter_name = "WHERE  Day(TimeArrival) = '" + comboBox5.Text + "'";
                if (filter == "fullDate")
                    filter_name = "WHERE  TimeArrival = '" + comboBox6.Text + "'";

            }*/
        
            dataAdapter = new SqlDataAdapter("SELECT  dbo.journal.journalID, dbo.driver.FullName, dbo.brand.model, dbo.car.CarNumbers, dbo.route.cargo, " +
                            "\n dbo.route.EstimatedTime, dbo.trip.DepartureAdress,   dbo.trip.ArrivalAdress, " +
                            "Format(dbo.journal.DepartureDate,'yyyy-dd-MM HH:mm:ss')," +
                            "\nFormat(dbo.journal.ArrivalDate,'yyyy-dd-MM HH:mm:ss'), dbo.trip.DepartureAdress, dbo.trip.ArrivalAdress,dbo.journal.price," +
                            "dbo.journal.driverID, dbo.journal.carID, dbo.journal.tripID, dbo.route.routeID" +
                            "\nFROM  dbo.journal INNER JOIN " +
                            "\ndbo.driver ON dbo.journal.driverID = dbo.driver.driverID INNER JOIN" +
                         "\ndbo.category ON dbo.driver.categoryID = dbo.category.categoryID INNER JOIN" +
                         "\ndbo.car ON dbo.journal.carID = dbo.car.carID INNER JOIN" +
                         "\ndbo.brand ON dbo.car.brandID = dbo.brand.brandID INNER JOIN" +
                         "\ndbo.trip ON dbo.journal.tripID = dbo.trip.tripID INNER JOIN" +
                         "\ndbo.route ON dbo.trip.routeID = dbo.route.routeID", Program.mainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            GVwriteData.DataSource = dataTable;
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string journalIDDel = GVwriteData.CurrentRow.Cells[0].Value.ToString();
            string nameString = GVwriteData.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Удалить строку с № " + nameString, " Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "Delete FROM journal WHERE journalID = " + journalIDDel;
                SqlCommand cmd = new SqlCommand(sqlExpression, Program.mainForm.connect);
                int number = cmd.ExecuteNonQuery();
            }

            this.writeDataTableAdapter.Fill(this.autobaseDataSet.writeData);

            if (dataAdapter != null)
                UpdateView("");
        }
    }
}
