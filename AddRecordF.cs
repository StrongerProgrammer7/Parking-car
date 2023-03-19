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
    public partial class AddRecordF : Form
    {
        string m_journalID;
        string m_driverID;
        string m_carID;
        string m_goodzID;
        
        public AddRecordF(string _journalID, string _driverID, string _carID,string _goodzID)
        {
            InitializeComponent();
            m_journalID = _journalID;
            m_driverID = _driverID;
            m_carID = _carID;
            m_goodzID = _goodzID;
          
            try
            {
                if (m_journalID != null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT  dbo.journal.journalID, dbo.driver.driverID, dbo.brand.brandID, dbo.car.carID, dbo.route.routeID, " +
                            "\ndbo.trip.tripID, Format(dbo.journal.DepartureDate,'yyyy-dd-MM HH:mm:ss')," +
                            "\nFormat(dbo.journal.ArrivalDate,'yyyy-dd-MM HH:mm:ss'), dbo.journal.price,dbo.trip.DepartureAdress, dbo.trip.ArrivalAdress" +
                            "\nFROM            dbo.journal INNER JOIN " +
                            "\ndbo.driver ON dbo.journal.driverID = dbo.driver.driverID INNER JOIN" +
                         "\ndbo.category ON dbo.driver.categoryID = dbo.category.categoryID INNER JOIN" +
                         "\ndbo.car ON dbo.journal.carID = dbo.car.carID INNER JOIN" +
                         "\ndbo.brand ON dbo.car.brandID = dbo.brand.brandID INNER JOIN" +
                         "\ndbo.trip ON dbo.journal.tripID = dbo.trip.tripID INNER JOIN" +
                         "\ndbo.route ON dbo.trip.routeID = dbo.route.routeID Where journal.journalID = " + m_journalID;
                
                    cmd.Connection = Program.mainForm.connect;
                    // cmd.Connection.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        m_driverID = rd.GetValue(1).ToString();
                        m_carID = rd.GetValue(2).ToString();
                        m_goodzID = rd.GetValue(4).ToString();
                        CBSurname.SelectedValue = m_driverID;
                        CBgoodz.SelectedValue = m_goodzID;
                        CBCar.SelectedValue = m_carID;

                        TBDateArriv.Text = rd.GetValue(7).ToString().Trim();
                        TBDateDepr.Text = rd.GetValue(6).ToString().Trim();

                        TBAddrArriv.Text = rd.GetValue(10).ToString().Trim();
                        TBAddrDep.Text = rd.GetValue(9).ToString().Trim();

                        TBprice.Text = rd.GetValue(8).ToString().Trim();
                    }
                    rd.Close();
                }else
                {
                    TBDateDepr.Text = DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss");
                    TBDateArriv.Text = DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss");
                }
                if (_driverID != null)
                {
                    CBSurname.SelectedValue = _driverID;
                }
                if (_goodzID != null)
                    CBgoodz.SelectedValue = _goodzID;
                if (_carID != null)
                    CBCar.SelectedValue = _carID;

            }
            catch (System.Data.Common.DbException)
            {
                System.Windows.Forms.MessageBox.Show("Error access to" +
                    "data base.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddRecordF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.autobaseDataSet.route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.brand". При необходимости она может быть перемещена или удалена.
            this.brandTableAdapter.Fill(this.autobaseDataSet.brand);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.autobaseDataSet.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.autobaseDataSet.driver);
            if (m_driverID != null)
            {
                CBSurname.SelectedValue = m_driverID;
                
            }
            if (m_carID != null)
            {
                CBCar.SelectedValue = m_carID;
            }
            if (m_goodzID != null)
                CBgoodz.SelectedValue = m_goodzID;
        }

        private void ButOk_Click(object sender, EventArgs e)
        {
            if (checkInput() == false)
                return;

            SqlParameter Param;
            SqlCommand cmd;
            int number = 0;
            if (m_journalID != null)
            {
                //Change
                string sqlExpression = "";
                sqlExpression = "Update trip " +
                    "SET trip.ArrivalAdress = '" + TBAddrArriv.Text + "'" +
                    " FROM journal" +
                    " Where (journal.driverID = " + CBSurname.SelectedValue.ToString() + ") AND (journal.tripID = trip.tripID) AND (journal.journalID = " + m_journalID + ")";
                

                cmd = new SqlCommand(sqlExpression, Program.mainForm.connect);
                number = cmd.ExecuteNonQuery();

                sqlExpression = "Update trip " +
                    "SET trip.DepartureAdress = '" + TBAddrDep.Text + "'" +
                    " FROM journal" +
                    " Where (journal.driverID = " + CBSurname.SelectedValue.ToString() + ") AND (journal.tripID = trip.tripID) AND (journal.journalID = " + m_journalID + ")";
                cmd = new SqlCommand(sqlExpression, Program.mainForm.connect);
                number = cmd.ExecuteNonQuery();

                sqlExpression = "Update journal " +
                    "SET journal.ArrivalDate = '" + TBDateArriv.Text + "'" +
                    " FROM journal" +
                    " Where (journal.driverID = " + CBSurname.SelectedValue.ToString() + ") AND (journal.journalID = " + m_journalID + ")";
                cmd = new SqlCommand(sqlExpression, Program.mainForm.connect);
                number = cmd.ExecuteNonQuery();

                sqlExpression = "Update journal " +
                    "SET journal.DepartureDate = '" + TBDateDepr.Text + "'" +
                    " FROM journal" +
                    " Where (journal.driverID = " + CBSurname.SelectedValue.ToString() + ") AND (journal.journalID = " + m_journalID + ")";
                cmd = new SqlCommand(sqlExpression, Program.mainForm.connect);
                number = cmd.ExecuteNonQuery();

                sqlExpression = "Update journal " +
                   "SET journal.price = '" + TBprice.Text + "'" +
                   " FROM journal" +
                   " Where (journal.driverID = " + CBSurname.SelectedValue.ToString() + ") AND (journal.journalID = " + m_journalID + ")";
                cmd = new SqlCommand(sqlExpression, Program.mainForm.connect);
                number = cmd.ExecuteNonQuery();
            }
            else
            {
                //add
               string sqlExpression = "";
                sqlExpression = "INSERT INTO trip ([routeID],[ArrivalAdress],[DepartureAdress]) " + "VALUES (@rout,@addrArr,@addrDepar)";

                cmd = new SqlCommand(sqlExpression, Program.mainForm.connect);
                // // добавили параметр команде
                Param = new SqlParameter("@rout", CBgoodz.SelectedValue.ToString());
                cmd.Parameters.Add(Param);
                Param = new SqlParameter("@addrArr", TBAddrArriv.Text);
                cmd.Parameters.Add(Param);
                Param = new SqlParameter("@addrDepar", TBAddrDep.Text);
                cmd.Parameters.Add(Param);
                number = cmd.ExecuteNonQuery();

                string sqlExpression2 = "";
                sqlExpression2 = "INSERT INTO journal ([driverID],[carID],[tripID],[DepartureDate],[ArrivalDate],[price]) VALUES " +
                    "(@driver," +
                    " (Select car.carID From car Where car.brandID =" + CBCar.SelectedValue.ToString() +
                    ")," +
                    "(Select trip.tripID From trip Where trip.routeID =" + CBgoodz.SelectedValue.ToString() + 
                    " AND trip.ArrivalAdress = '"+ TBAddrArriv.Text + "' AND trip.DepartureAdress = '"+ TBAddrDep.Text + "'),@depDate,@arrDate,@price)";

                cmd = new SqlCommand(sqlExpression2, Program.mainForm.connect);
                Param = new SqlParameter("@driver", CBSurname.SelectedValue.ToString()); 
                cmd.Parameters.Add(Param);
                Param = new SqlParameter("@depDate", TBDateDepr.Text); 
                cmd.Parameters.Add(Param);
                Param = new SqlParameter("@arrDate", TBDateArriv.Text); 
                cmd.Parameters.Add(Param);
                Param = new SqlParameter("@price", TBprice.Text); 
                cmd.Parameters.Add(Param);
                number = cmd.ExecuteNonQuery();
            }

            this.Close();
        }
        private bool checkInput()
        {
            if (TBAddrArriv.Text.Length == 0)
            {
                MessageBox.Show("Введите адрес прибытия .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TBAddrDep.Text.Length == 0)
            {
                MessageBox.Show("Введите адрес убытия .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CBCar.SelectedIndex < 0)
            {
                MessageBox.Show("Введите данные об авто", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CBSurname.SelectedIndex < 0)
            {
                MessageBox.Show("Введите данные о владельце", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CBgoodz.SelectedIndex < 0)
            {
                MessageBox.Show("Введите данные о товаре", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButInforDriver_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Driver"] == null)
                new Driver().Show();
        }

        private void ButInfCar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Car"] == null)
                new Car().Show();
        }

        private void ButInformTrip_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Trip"] == null)
                new Trip().Show();
        }
    }
}
