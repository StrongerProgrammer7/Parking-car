
namespace Autobase
{
    partial class WriteData
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GVwriteData = new System.Windows.Forms.DataGridView();
            this.writeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobaseDataSet = new Autobase.AutobaseDataSet();
            this.writeDataTableAdapter = new Autobase.AutobaseDataSetTableAdapters.writeDataTableAdapter();
            this.writeDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.journalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumbersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVwriteData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem,
            this.changeRecordToolStripMenuItem,
            this.deleteRecordToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.addRecordToolStripMenuItem.Text = "AddRecord";
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
            // 
            // changeRecordToolStripMenuItem
            // 
            this.changeRecordToolStripMenuItem.Name = "changeRecordToolStripMenuItem";
            this.changeRecordToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.changeRecordToolStripMenuItem.Text = "ChangeRecord";
            this.changeRecordToolStripMenuItem.Click += new System.EventHandler(this.changeRecordToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.deleteRecordToolStripMenuItem.Text = "DeleteRecord";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // GVwriteData
            // 
            this.GVwriteData.AllowUserToAddRows = false;
            this.GVwriteData.AllowUserToDeleteRows = false;
            this.GVwriteData.AutoGenerateColumns = false;
            this.GVwriteData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVwriteData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.journalIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.carNumbersDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.estimatedTimeDataGridViewTextBoxColumn,
            this.departureAdressDataGridViewTextBoxColumn,
            this.arrivalAdressDataGridViewTextBoxColumn,
            this.departureDateDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.driverID,
            this.carID,
            this.tripID,
            this.routeID});
            this.GVwriteData.DataSource = this.writeDataBindingSource;
            this.GVwriteData.Location = new System.Drawing.Point(12, 36);
            this.GVwriteData.Name = "GVwriteData";
            this.GVwriteData.ReadOnly = true;
            this.GVwriteData.Size = new System.Drawing.Size(1402, 402);
            this.GVwriteData.TabIndex = 1;
            // 
            // writeDataBindingSource
            // 
            this.writeDataBindingSource.DataMember = "writeData";
            this.writeDataBindingSource.DataSource = this.autobaseDataSet;
            // 
            // autobaseDataSet
            // 
            this.autobaseDataSet.DataSetName = "AutobaseDataSet";
            this.autobaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // writeDataTableAdapter
            // 
            this.writeDataTableAdapter.ClearBeforeFill = true;
            // 
            // writeDataBindingSource1
            // 
            this.writeDataBindingSource1.DataMember = "writeData";
            this.writeDataBindingSource1.DataSource = this.autobaseDataSet;
            // 
            // journalIDDataGridViewTextBoxColumn
            // 
            this.journalIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.journalIDDataGridViewTextBoxColumn.DataPropertyName = "journalID";
            this.journalIDDataGridViewTextBoxColumn.HeaderText = "journalID";
            this.journalIDDataGridViewTextBoxColumn.Name = "journalIDDataGridViewTextBoxColumn";
            this.journalIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.journalIDDataGridViewTextBoxColumn.Width = 5;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 5;
            // 
            // carNumbersDataGridViewTextBoxColumn
            // 
            this.carNumbersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.carNumbersDataGridViewTextBoxColumn.DataPropertyName = "CarNumbers";
            this.carNumbersDataGridViewTextBoxColumn.HeaderText = "CarNumbers";
            this.carNumbersDataGridViewTextBoxColumn.Name = "carNumbersDataGridViewTextBoxColumn";
            this.carNumbersDataGridViewTextBoxColumn.ReadOnly = true;
            this.carNumbersDataGridViewTextBoxColumn.Width = 5;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoDataGridViewTextBoxColumn.Width = 5;
            // 
            // estimatedTimeDataGridViewTextBoxColumn
            // 
            this.estimatedTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.estimatedTimeDataGridViewTextBoxColumn.DataPropertyName = "EstimatedTime";
            this.estimatedTimeDataGridViewTextBoxColumn.HeaderText = "EstimatedTime";
            this.estimatedTimeDataGridViewTextBoxColumn.Name = "estimatedTimeDataGridViewTextBoxColumn";
            this.estimatedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.estimatedTimeDataGridViewTextBoxColumn.Width = 5;
            // 
            // departureAdressDataGridViewTextBoxColumn
            // 
            this.departureAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departureAdressDataGridViewTextBoxColumn.DataPropertyName = "DepartureAdress";
            this.departureAdressDataGridViewTextBoxColumn.HeaderText = "DepartureAdress";
            this.departureAdressDataGridViewTextBoxColumn.Name = "departureAdressDataGridViewTextBoxColumn";
            this.departureAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureAdressDataGridViewTextBoxColumn.Width = 111;
            // 
            // arrivalAdressDataGridViewTextBoxColumn
            // 
            this.arrivalAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.arrivalAdressDataGridViewTextBoxColumn.DataPropertyName = "ArrivalAdress";
            this.arrivalAdressDataGridViewTextBoxColumn.HeaderText = "ArrivalAdress";
            this.arrivalAdressDataGridViewTextBoxColumn.Name = "arrivalAdressDataGridViewTextBoxColumn";
            this.arrivalAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalAdressDataGridViewTextBoxColumn.Width = 93;
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            this.departureDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureDateDataGridViewTextBoxColumn.Width = 102;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            this.arrivalDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalDateDataGridViewTextBoxColumn.Width = 84;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 5;
            // 
            // driverID
            // 
            this.driverID.DataPropertyName = "driverID";
            this.driverID.HeaderText = "driverID";
            this.driverID.Name = "driverID";
            this.driverID.ReadOnly = true;
            this.driverID.Visible = false;
            // 
            // carID
            // 
            this.carID.DataPropertyName = "carID";
            this.carID.HeaderText = "carID";
            this.carID.Name = "carID";
            this.carID.ReadOnly = true;
            this.carID.Visible = false;
            // 
            // tripID
            // 
            this.tripID.DataPropertyName = "tripID";
            this.tripID.HeaderText = "tripID";
            this.tripID.Name = "tripID";
            this.tripID.ReadOnly = true;
            this.tripID.Visible = false;
            // 
            // routeID
            // 
            this.routeID.DataPropertyName = "routeID";
            this.routeID.HeaderText = "routeID";
            this.routeID.Name = "routeID";
            this.routeID.ReadOnly = true;
            this.routeID.Visible = false;
            // 
            // WriteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 450);
            this.Controls.Add(this.GVwriteData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WriteData";
            this.Text = "WriteData";
            this.Activated += new System.EventHandler(this.WriteData_Activated);
            this.Load += new System.EventHandler(this.WriteData_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVwriteData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView GVwriteData;
        private AutobaseDataSet autobaseDataSet;
        private System.Windows.Forms.BindingSource writeDataBindingSource;
        private AutobaseDataSetTableAdapters.writeDataTableAdapter writeDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn journalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn carID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeID;
        private System.Windows.Forms.BindingSource writeDataBindingSource1;
    }
}