
namespace Autobase
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel_butt = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
            this.rbexportHTML = new System.Windows.Forms.RadioButton();
            this.rbexportExcel = new System.Windows.Forms.RadioButton();
            this.form_export = new System.Windows.Forms.Label();
            this.CHK_dailyList = new System.Windows.Forms.CheckBox();
            this.CHK_travelList = new System.Windows.Forms.CheckBox();
            this.autobaseDataSet1 = new Autobase.AutobaseDataSet();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.travelListTableAdapter1 = new Autobase.AutobaseDataSetTableAdapters.travelListTableAdapter();
            this.dailyTripsTableAdapter1 = new Autobase.AutobaseDataSetTableAdapters.dailyTripsTableAdapter();
            this.exportCrystal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 3);
            this.label1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(21, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 3);
            this.label2.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cancel_butt
            // 
            this.cancel_butt.Location = new System.Drawing.Point(97, 192);
            this.cancel_butt.Name = "cancel_butt";
            this.cancel_butt.Size = new System.Drawing.Size(75, 23);
            this.cancel_butt.TabIndex = 20;
            this.cancel_butt.Text = "Вернуться";
            this.cancel_butt.UseVisualStyleBackColor = true;
            this.cancel_butt.Click += new System.EventHandler(this.cancel_butt_Click);
            // 
            // export_button
            // 
            this.export_button.Location = new System.Drawing.Point(9, 192);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(75, 23);
            this.export_button.TabIndex = 19;
            this.export_button.Text = "Экспорт";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // rbexportHTML
            // 
            this.rbexportHTML.AutoSize = true;
            this.rbexportHTML.BackColor = System.Drawing.Color.Transparent;
            this.rbexportHTML.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbexportHTML.ForeColor = System.Drawing.Color.Olive;
            this.rbexportHTML.Location = new System.Drawing.Point(35, 125);
            this.rbexportHTML.Name = "rbexportHTML";
            this.rbexportHTML.Size = new System.Drawing.Size(117, 19);
            this.rbexportHTML.TabIndex = 18;
            this.rbexportHTML.TabStop = true;
            this.rbexportHTML.Text = "Экспорт в HTML";
            this.rbexportHTML.UseVisualStyleBackColor = false;
            // 
            // rbexportExcel
            // 
            this.rbexportExcel.AutoSize = true;
            this.rbexportExcel.BackColor = System.Drawing.Color.Transparent;
            this.rbexportExcel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbexportExcel.ForeColor = System.Drawing.Color.Maroon;
            this.rbexportExcel.Location = new System.Drawing.Point(35, 102);
            this.rbexportExcel.Name = "rbexportExcel";
            this.rbexportExcel.Size = new System.Drawing.Size(110, 19);
            this.rbexportExcel.TabIndex = 17;
            this.rbexportExcel.TabStop = true;
            this.rbexportExcel.Text = "Экспорт в Excel";
            this.rbexportExcel.UseVisualStyleBackColor = false;
            // 
            // form_export
            // 
            this.form_export.AutoSize = true;
            this.form_export.BackColor = System.Drawing.Color.Transparent;
            this.form_export.Location = new System.Drawing.Point(39, 77);
            this.form_export.Name = "form_export";
            this.form_export.Size = new System.Drawing.Size(94, 13);
            this.form_export.TabIndex = 16;
            this.form_export.Text = "Форма экспорта";
            // 
            // CHK_dailyList
            // 
            this.CHK_dailyList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CHK_dailyList.AutoSize = true;
            this.CHK_dailyList.BackColor = System.Drawing.Color.Transparent;
            this.CHK_dailyList.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CHK_dailyList.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHK_dailyList.Location = new System.Drawing.Point(46, 44);
            this.CHK_dailyList.Name = "CHK_dailyList";
            this.CHK_dailyList.Size = new System.Drawing.Size(123, 34);
            this.CHK_dailyList.TabIndex = 15;
            this.CHK_dailyList.Text = "Отчет - суточные\r\n ";
            this.CHK_dailyList.UseVisualStyleBackColor = false;
            // 
            // CHK_travelList
            // 
            this.CHK_travelList.AutoSize = true;
            this.CHK_travelList.BackColor = System.Drawing.Color.Transparent;
            this.CHK_travelList.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHK_travelList.Location = new System.Drawing.Point(46, 12);
            this.CHK_travelList.Name = "CHK_travelList";
            this.CHK_travelList.Size = new System.Drawing.Size(143, 19);
            this.CHK_travelList.TabIndex = 14;
            this.CHK_travelList.Text = "Отчет - путевой лист\r\n";
            this.CHK_travelList.UseVisualStyleBackColor = false;
            // 
            // autobaseDataSet1
            // 
            this.autobaseDataSet1.DataSetName = "AutobaseDataSet";
            this.autobaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // travelListTableAdapter1
            // 
            this.travelListTableAdapter1.ClearBeforeFill = true;
            // 
            // dailyTripsTableAdapter1
            // 
            this.dailyTripsTableAdapter1.ClearBeforeFill = true;
            // 
            // exportCrystal
            // 
            this.exportCrystal.AutoSize = true;
            this.exportCrystal.BackColor = System.Drawing.Color.Transparent;
            this.exportCrystal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportCrystal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exportCrystal.Location = new System.Drawing.Point(35, 150);
            this.exportCrystal.Name = "exportCrystal";
            this.exportCrystal.Size = new System.Drawing.Size(112, 19);
            this.exportCrystal.TabIndex = 25;
            this.exportCrystal.TabStop = true;
            this.exportCrystal.Text = "Экспорт Crystal";
            this.exportCrystal.UseVisualStyleBackColor = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 221);
            this.Controls.Add(this.exportCrystal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel_butt);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.rbexportHTML);
            this.Controls.Add(this.rbexportExcel);
            this.Controls.Add(this.form_export);
            this.Controls.Add(this.CHK_dailyList);
            this.Controls.Add(this.CHK_travelList);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancel_butt;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.RadioButton rbexportHTML;
        private System.Windows.Forms.RadioButton rbexportExcel;
        private System.Windows.Forms.Label form_export;
        private System.Windows.Forms.CheckBox CHK_dailyList;
        private System.Windows.Forms.CheckBox CHK_travelList;
        private AutobaseDataSet autobaseDataSet1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private AutobaseDataSetTableAdapters.travelListTableAdapter travelListTableAdapter1;
        private AutobaseDataSetTableAdapters.dailyTripsTableAdapter dailyTripsTableAdapter1;
        private System.Windows.Forms.RadioButton exportCrystal;
    }
}