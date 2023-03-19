
namespace Autobase
{
    partial class AddRecordF
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButOk = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.CBSurname = new System.Windows.Forms.ComboBox();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobaseDataSet = new Autobase.AutobaseDataSet();
            this.CBCar = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBAddrDep = new System.Windows.Forms.TextBox();
            this.TBAddrArriv = new System.Windows.Forms.TextBox();
            this.TBDateDepr = new System.Windows.Forms.TextBox();
            this.TBDateArriv = new System.Windows.Forms.TextBox();
            this.ButInfCar = new System.Windows.Forms.Button();
            this.ButInforDriver = new System.Windows.Forms.Button();
            this.ButInformTrip = new System.Windows.Forms.Button();
            this.driverTableAdapter = new Autobase.AutobaseDataSetTableAdapters.driverTableAdapter();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new Autobase.AutobaseDataSetTableAdapters.carTableAdapter();
            this.brandTableAdapter = new Autobase.AutobaseDataSetTableAdapters.brandTableAdapter();
            this.CBgoodz = new System.Windows.Forms.ComboBox();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.routeTableAdapter = new Autobase.AutobaseDataSetTableAdapters.routeTableAdapter();
            this.TBprice = new System.Windows.Forms.TextBox();
            this.LBprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО водителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автомобиль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адрес отправления:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес прибытия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата убытия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата прибытия";
            // 
            // ButOk
            // 
            this.ButOk.Location = new System.Drawing.Point(23, 309);
            this.ButOk.Name = "ButOk";
            this.ButOk.Size = new System.Drawing.Size(75, 23);
            this.ButOk.TabIndex = 6;
            this.ButOk.Text = "OK";
            this.ButOk.UseVisualStyleBackColor = true;
            this.ButOk.Click += new System.EventHandler(this.ButOk_Click);
            // 
            // ButCancel
            // 
            this.ButCancel.Location = new System.Drawing.Point(161, 309);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(75, 23);
            this.ButCancel.TabIndex = 7;
            this.ButCancel.Text = "Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // CBSurname
            // 
            this.CBSurname.DataSource = this.driverBindingSource;
            this.CBSurname.DisplayMember = "FullName";
            this.CBSurname.FormattingEnabled = true;
            this.CBSurname.Location = new System.Drawing.Point(105, 19);
            this.CBSurname.Name = "CBSurname";
            this.CBSurname.Size = new System.Drawing.Size(169, 21);
            this.CBSurname.TabIndex = 8;
            this.CBSurname.ValueMember = "driverID";
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "driver";
            this.driverBindingSource.DataSource = this.autobaseDataSet;
            // 
            // autobaseDataSet
            // 
            this.autobaseDataSet.DataSetName = "AutobaseDataSet";
            this.autobaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBCar
            // 
            this.CBCar.DataSource = this.brandBindingSource;
            this.CBCar.DisplayMember = "model";
            this.CBCar.FormattingEnabled = true;
            this.CBCar.Location = new System.Drawing.Point(105, 50);
            this.CBCar.Name = "CBCar";
            this.CBCar.Size = new System.Drawing.Size(169, 21);
            this.CBCar.TabIndex = 9;
            this.CBCar.ValueMember = "brandID";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.autobaseDataSet;
            // 
            // TBAddrDep
            // 
            this.TBAddrDep.Location = new System.Drawing.Point(15, 131);
            this.TBAddrDep.Name = "TBAddrDep";
            this.TBAddrDep.Size = new System.Drawing.Size(259, 20);
            this.TBAddrDep.TabIndex = 10;
            // 
            // TBAddrArriv
            // 
            this.TBAddrArriv.Location = new System.Drawing.Point(15, 179);
            this.TBAddrArriv.Name = "TBAddrArriv";
            this.TBAddrArriv.Size = new System.Drawing.Size(259, 20);
            this.TBAddrArriv.TabIndex = 11;
            // 
            // TBDateDepr
            // 
            this.TBDateDepr.Location = new System.Drawing.Point(12, 227);
            this.TBDateDepr.Name = "TBDateDepr";
            this.TBDateDepr.Size = new System.Drawing.Size(262, 20);
            this.TBDateDepr.TabIndex = 12;
            // 
            // TBDateArriv
            // 
            this.TBDateArriv.Location = new System.Drawing.Point(12, 273);
            this.TBDateArriv.Name = "TBDateArriv";
            this.TBDateArriv.Size = new System.Drawing.Size(262, 20);
            this.TBDateArriv.TabIndex = 13;
            // 
            // ButInfCar
            // 
            this.ButInfCar.Location = new System.Drawing.Point(280, 49);
            this.ButInfCar.Name = "ButInfCar";
            this.ButInfCar.Size = new System.Drawing.Size(109, 23);
            this.ButInfCar.TabIndex = 14;
            this.ButInfCar.Text = "Information Car";
            this.ButInfCar.UseVisualStyleBackColor = true;
            this.ButInfCar.Click += new System.EventHandler(this.ButInfCar_Click);
            // 
            // ButInforDriver
            // 
            this.ButInforDriver.Location = new System.Drawing.Point(280, 18);
            this.ButInforDriver.Name = "ButInforDriver";
            this.ButInforDriver.Size = new System.Drawing.Size(109, 23);
            this.ButInforDriver.TabIndex = 15;
            this.ButInforDriver.Text = "Information Driver";
            this.ButInforDriver.UseVisualStyleBackColor = true;
            this.ButInforDriver.Click += new System.EventHandler(this.ButInforDriver_Click);
            // 
            // ButInformTrip
            // 
            this.ButInformTrip.Location = new System.Drawing.Point(280, 79);
            this.ButInformTrip.Name = "ButInformTrip";
            this.ButInformTrip.Size = new System.Drawing.Size(109, 23);
            this.ButInformTrip.TabIndex = 16;
            this.ButInformTrip.Text = "Information Trip";
            this.ButInformTrip.UseVisualStyleBackColor = true;
            this.ButInformTrip.Click += new System.EventHandler(this.ButInformTrip_Click);
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.autobaseDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // CBgoodz
            // 
            this.CBgoodz.DataSource = this.routeBindingSource;
            this.CBgoodz.DisplayMember = "cargo";
            this.CBgoodz.FormattingEnabled = true;
            this.CBgoodz.Location = new System.Drawing.Point(105, 81);
            this.CBgoodz.Name = "CBgoodz";
            this.CBgoodz.Size = new System.Drawing.Size(169, 21);
            this.CBgoodz.TabIndex = 18;
            this.CBgoodz.ValueMember = "routeID";
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "route";
            this.routeBindingSource.DataSource = this.autobaseDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Товар";
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // TBprice
            // 
            this.TBprice.Location = new System.Drawing.Point(280, 315);
            this.TBprice.Name = "TBprice";
            this.TBprice.Size = new System.Drawing.Size(90, 20);
            this.TBprice.TabIndex = 19;
            // 
            // LBprice
            // 
            this.LBprice.AutoSize = true;
            this.LBprice.Location = new System.Drawing.Point(308, 295);
            this.LBprice.Name = "LBprice";
            this.LBprice.Size = new System.Drawing.Size(33, 13);
            this.LBprice.TabIndex = 20;
            this.LBprice.Text = "Цена";
            // 
            // AddRecordF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 347);
            this.Controls.Add(this.LBprice);
            this.Controls.Add(this.TBprice);
            this.Controls.Add(this.CBgoodz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButInformTrip);
            this.Controls.Add(this.ButInforDriver);
            this.Controls.Add(this.ButInfCar);
            this.Controls.Add(this.TBDateArriv);
            this.Controls.Add(this.TBDateDepr);
            this.Controls.Add(this.TBAddrArriv);
            this.Controls.Add(this.TBAddrDep);
            this.Controls.Add(this.CBCar);
            this.Controls.Add(this.CBSurname);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRecordF";
            this.Text = "AddRecordF";
            this.Load += new System.EventHandler(this.AddRecordF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButOk;
        private System.Windows.Forms.Button ButCancel;
        private System.Windows.Forms.ComboBox CBSurname;
        private System.Windows.Forms.ComboBox CBCar;
        private System.Windows.Forms.TextBox TBAddrDep;
        private System.Windows.Forms.TextBox TBAddrArriv;
        private System.Windows.Forms.TextBox TBDateDepr;
        private System.Windows.Forms.TextBox TBDateArriv;
        private System.Windows.Forms.Button ButInfCar;
        private System.Windows.Forms.Button ButInforDriver;
        private System.Windows.Forms.Button ButInformTrip;
        private AutobaseDataSet autobaseDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private AutobaseDataSetTableAdapters.driverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource carBindingSource;
        private AutobaseDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private AutobaseDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.ComboBox CBgoodz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private AutobaseDataSetTableAdapters.routeTableAdapter routeTableAdapter;
        private System.Windows.Forms.TextBox TBprice;
        private System.Windows.Forms.Label LBprice;
    }
}