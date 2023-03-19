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
    public partial class AutobaseF : Form
    {
        public SqlConnection connect;
        public SqlDataAdapter dataAdapter = null;

        public AutobaseF()
        {
            InitializeComponent();
        }

        private void AutobaseF_Load(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=localhost;Initial Catalog=Autobase;Integrated Security=True";
            this.connect = new SqlConnection(connectionString);
            try
            {
                this.connect.Open();
                // MessageBox.Show("Open Server");
            }

            catch
            {
                MessageBox.Show("Error access to data base.");
            }
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Car"] == null)
                new Car().Show();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Driver"] == null)
                new Driver().Show();
        }

        private void tripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Trip"] == null)
                new Trip().Show();
        }
        private void writeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["WriteData"] == null)
                new WriteData().Show();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["About"] == null)
                new About().Show();
        }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Report"] == null)
                new Report().Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
