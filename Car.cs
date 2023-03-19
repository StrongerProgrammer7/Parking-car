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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void Car_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.brand". При необходимости она может быть перемещена или удалена.
            this.brandTableAdapter.Fill(this.autobaseDataSet.brand);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.autobaseDataSet.car);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //запись данных из grid в datasset
                GVcar.DataSource = autobaseDataSet.car;
                GVbrand.DataSource = autobaseDataSet.brand;
                

                carTableAdapter.Update(autobaseDataSet);
                brandTableAdapter.Update(autobaseDataSet);
              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager curRec = (CurrencyManager)GVcar.BindingContext[GVcar.DataSource];
                //в буф табл запись тек табл из datagrid
                deleteRecord(curRec);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager curRec = (CurrencyManager)GVbrand.BindingContext[GVbrand.DataSource];
                //в буф табл запись тек табл из datagrid
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
            if (curRec == (CurrencyManager)GVcar.BindingContext[GVcar.DataSource])
                carTableAdapter.Update(autobaseDataSet);
            if (curRec == (CurrencyManager)GVbrand.BindingContext[GVbrand.DataSource])
                brandTableAdapter.Update(autobaseDataSet);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
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
