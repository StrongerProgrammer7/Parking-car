using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autobase
{
    public partial class Trip : Form
    {
        public Trip()
        {
            InitializeComponent();
        }

        private void Trip_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.autobaseDataSet.route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.trip". При необходимости она может быть перемещена или удалена.
            this.tripTableAdapter.Fill(this.autobaseDataSet.trip);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //запись данных из grid в datasset
                GVtrip.DataSource = autobaseDataSet.trip;
                GVroute.DataSource = autobaseDataSet.route;


                tripTableAdapter.Update(autobaseDataSet);
                routeTableAdapter.Update(autobaseDataSet);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void tripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager curRec = (CurrencyManager)GVtrip.BindingContext[GVtrip.DataSource];
                deleteRecord(curRec);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void routeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager curRec = (CurrencyManager)GVroute.BindingContext[GVroute.DataSource];
                deleteRecord(curRec);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
        private void deleteRecord(CurrencyManager curRec)
        {
            try
            {
                //в буф табл запись тек табл из datagrid
                if (curRec.Count > 0)
                {
                    curRec.RemoveAt(curRec.Position);// отмеч позиция удаляется
                    updateRecord(curRec);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void updateRecord(CurrencyManager curRec)
        {
            if (curRec == (CurrencyManager)GVtrip.BindingContext[GVtrip.DataSource])
                tripTableAdapter.Update(autobaseDataSet);
            if (curRec == (CurrencyManager)GVroute.BindingContext[GVroute.DataSource])
                routeTableAdapter.Update(autobaseDataSet);
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
    }
}
