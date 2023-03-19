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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.autobaseDataSet.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autobaseDataSet.driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.autobaseDataSet.driver);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //запись данных из grid в datasset
                GVdriver.DataSource = autobaseDataSet.driver;
                GVcategory.DataSource = autobaseDataSet.category;


                driverTableAdapter.Update(autobaseDataSet);
                categoryTableAdapter.Update(autobaseDataSet);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager curRec = (CurrencyManager)GVdriver.BindingContext[GVdriver.DataSource];
                deleteRecord(curRec);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager curRec = (CurrencyManager)GVcategory.BindingContext[GVcategory.DataSource];
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
            if (curRec == (CurrencyManager)GVdriver.BindingContext[GVdriver.DataSource])
                driverTableAdapter.Update(autobaseDataSet);
            if (curRec == (CurrencyManager)GVcategory.BindingContext[GVcategory.DataSource])
                categoryTableAdapter.Update(autobaseDataSet);
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
