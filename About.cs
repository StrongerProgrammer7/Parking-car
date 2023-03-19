using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Autobase
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            try
            {
                using (var file = new StreamReader("About.txt"))
                {
                    // Read the stream as a string, and write the string to the console.
                    //richTextBox1.Text = file.ReadToEnd();
                    richTextBox1.Text = File.ReadAllText("About.txt", Encoding.GetEncoding(1251));
                    file.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
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
