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
using System.Diagnostics;

namespace Autobase
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void export_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbexportExcel.Checked == true)
                {
                    saveFileDialog1.DefaultExt = "xls";
                    saveFileDialog1.Filter = "Excel files(*.xls)|*.xls";
                    saveFileDialog1.Title = " Экспорт: Excel";

                    if (CHK_dailyList.Checked == true && CHK_travelList.Checked == false)
                    {
                        dailyTripsTableAdapter1.Fill(autobaseDataSet1.dailyTrips);
                        exportToExcel(autobaseDataSet1.Tables[7]);//порядок предст идет от 0 в кнструкторе, предст как колл 12 timeout
                    }

                    if (CHK_dailyList.Checked == false && CHK_travelList.Checked == true)
                    {
                        travelListTableAdapter1.Fill(autobaseDataSet1.travelList);
                        exportToExcel(autobaseDataSet1.Tables[8]);


                    }
                    if (CHK_dailyList.Checked == true && CHK_travelList.Checked == true)
                    {
                        dailyTripsTableAdapter1.Fill(autobaseDataSet1.dailyTrips);
                        exportToExcel(autobaseDataSet1.Tables[7]);

                        travelListTableAdapter1.Fill(autobaseDataSet1.travelList);
                        exportToExcel(autobaseDataSet1.Tables[8]);
                    }
                }

                if (rbexportHTML.Checked == true)
                {
                    saveFileDialog1.DefaultExt = "html";
                    saveFileDialog1.Filter = " EHTML files(*.html)|*.html";
                    saveFileDialog1.Title = " Экспорт: HTML";
                    if (CHK_dailyList.Checked == true && CHK_travelList.Checked == false)
                    {
                        dailyTripsTableAdapter1.Fill(autobaseDataSet1.dailyTrips);
                        exportToHTML(autobaseDataSet1.Tables[7], "Отчет!");
                    }

                    if (CHK_dailyList.Checked == false && CHK_travelList.Checked == true)
                    {
                        travelListTableAdapter1.Fill(autobaseDataSet1.travelList);
                        exportToHTML(autobaseDataSet1.Tables[8], "Отчет!");
                    }
                    if (CHK_dailyList.Checked == true && CHK_travelList.Checked == true)
                    {
                        dailyTripsTableAdapter1.Fill(autobaseDataSet1.dailyTrips);
                        exportToHTML(autobaseDataSet1.Tables[7], "Отчет!");

                        travelListTableAdapter1.Fill(autobaseDataSet1.travelList);
                        exportToHTML(autobaseDataSet1.Tables[8], "Отчет!");
                    }
                }

                if (exportCrystal.Checked == true)
                {
                    if (CHK_dailyList.Checked == true)
                    {
                        if (Application.OpenForms["CRP_dayTrips"] == null)
                            new CRP_dayTrips().Show();
                    }

                    if (CHK_travelList.Checked == true)
                    {
                        if (Application.OpenForms["CRP_travelL"] == null)
                            new CRP_travelL().Show();
                    }
                   
                }
            }

            catch
            {

                MessageBox.Show("При передаче данных возникла ошибка!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void exportToExcel(DataTable table)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream stream1_fileExcel = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                try
                {
                    StreamWriter streamWriter_stream1_fileExcel = new StreamWriter(stream1_fileExcel, System.Text.Encoding.Unicode);

                    foreach (System.Data.DataColumn Column in table.Columns)
                        streamWriter_stream1_fileExcel.Write(Column.Caption + "\t");

                    streamWriter_stream1_fileExcel.WriteLine();

                    foreach (System.Data.DataRow row in table.Rows)
                    {
                        foreach (object entity in row.ItemArray)
                        {
                            streamWriter_stream1_fileExcel.Write(entity.ToString() + "\t");
                        }
                        streamWriter_stream1_fileExcel.WriteLine();
                    }
                    streamWriter_stream1_fileExcel.Flush();
                }

                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                stream1_fileExcel.Close();
                if (stream1_fileExcel.Name != null)
                    Process.Start(stream1_fileExcel.Name);
                else
                {
                    MessageBox.Show("Ошибка, данного файла не существует!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        void exportToHTML(DataTable table, string thisTitle)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream streamHTML = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                try
                {
                    StreamWriter strWrite_streamHTML = new StreamWriter(streamHTML);

                    strWrite_streamHTML.WriteLine("<!DOCTYPE html>");
                    strWrite_streamHTML.WriteLine("<html lang=\"en\">");
                    strWrite_streamHTML.WriteLine("<head>");
                    strWrite_streamHTML.WriteLine("<meta charset=\"UTF - 8\">");
                    strWrite_streamHTML.WriteLine("<meta http-equiv=\"X - UA - Compatible\" content=\"IE = edge\">");
                    strWrite_streamHTML.WriteLine("<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">");
                    strWrite_streamHTML.WriteLine("<title>" + thisTitle + "</title>");
                    strWrite_streamHTML.WriteLine("</head>");
                    strWrite_streamHTML.WriteLine("<body bgcolor=\"ffffff\">");
                    strWrite_streamHTML.WriteLine("<table border = \"1\" align=\"center\" cols =\"" + table.Columns.Count + "\" cellpadding=\"5\" cellspacing =\"0\">");
                    strWrite_streamHTML.WriteLine("<tr>");
                    strWrite_streamHTML.WriteLine("</td>");
                    strWrite_streamHTML.WriteLine("</tr>");
                    strWrite_streamHTML.WriteLine("<tr>");

                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        strWrite_streamHTML.WriteLine("<td><font face=\"Times New Roman\"size=\"3\"color=\"#000000\"><p align=\"center\"><b>");
                        strWrite_streamHTML.WriteLine("" + table.Columns[j].ColumnName);
                        strWrite_streamHTML.WriteLine("</b></p></font></td>");
                    }

                    strWrite_streamHTML.WriteLine("</tr>");
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            strWrite_streamHTML.WriteLine("<tr bgcolor=\"ffffff\">");
                            for (int j = 0; j < table.Columns.Count; j++)
                            {
                                strWrite_streamHTML.WriteLine("<td><font face=\"Times New Roman\"size=\"2\" color=\"#000000\"><p align=\"center\">");
                                strWrite_streamHTML.WriteLine("" + table.Rows[i][j]);
                                strWrite_streamHTML.WriteLine("</p></font></td>");
                            }

                            strWrite_streamHTML.WriteLine("</tr>");
                        }
                        else
                        {
                            strWrite_streamHTML.WriteLine("<tr>");
                            for (int j = 0; j < table.Columns.Count; j++)
                            {
                                strWrite_streamHTML.WriteLine("<td><font face=\"Times New Roman\"size=\"2\" color =\"#000000\"><p align=\"center\">");
                                strWrite_streamHTML.WriteLine("" + table.Rows[i][j]);
                                strWrite_streamHTML.WriteLine("</p></font></td>");
                            }
                            strWrite_streamHTML.WriteLine("</tr>");
                        }
                    }
                    strWrite_streamHTML.WriteLine("</table></body></html>");
                    MessageBox.Show("Экспорт завершен!", "Exp...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    strWrite_streamHTML.Flush();

                }
                catch (Exception)
                {

                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                streamHTML.Close();
                if (streamHTML.Name != null)
                    Process.Start(streamHTML.Name);
                else
                {
                    MessageBox.Show("Ошибка, данного файла не существует!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
