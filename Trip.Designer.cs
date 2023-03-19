
namespace Autobase
{
    partial class Trip
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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GVtrip = new System.Windows.Forms.DataGridView();
            this.tripIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobaseDataSet = new Autobase.AutobaseDataSet();
            this.GVroute = new System.Windows.Forms.DataGridView();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripTableAdapter = new Autobase.AutobaseDataSetTableAdapters.tripTableAdapter();
            this.routeTableAdapter = new Autobase.AutobaseDataSetTableAdapters.routeTableAdapter();
            this.routeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVtrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVroute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tripToolStripMenuItem,
            this.routeToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.deleteToolStripMenuItem.Text = "Delete...";
            // 
            // tripToolStripMenuItem
            // 
            this.tripToolStripMenuItem.Name = "tripToolStripMenuItem";
            this.tripToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tripToolStripMenuItem.Text = "trip";
            this.tripToolStripMenuItem.Click += new System.EventHandler(this.tripToolStripMenuItem_Click);
            // 
            // routeToolStripMenuItem
            // 
            this.routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            this.routeToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.routeToolStripMenuItem.Text = "route";
            this.routeToolStripMenuItem.Click += new System.EventHandler(this.routeToolStripMenuItem_Click);
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
            // GVtrip
            // 
            this.GVtrip.AutoGenerateColumns = false;
            this.GVtrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVtrip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripIDDataGridViewTextBoxColumn,
            this.routeIDDataGridViewTextBoxColumn,
            this.arrivalAdressDataGridViewTextBoxColumn,
            this.departureAdressDataGridViewTextBoxColumn});
            this.GVtrip.DataSource = this.tripBindingSource;
            this.GVtrip.Location = new System.Drawing.Point(12, 27);
            this.GVtrip.Name = "GVtrip";
            this.GVtrip.Size = new System.Drawing.Size(530, 187);
            this.GVtrip.TabIndex = 1;
            // 
            // tripIDDataGridViewTextBoxColumn
            // 
            this.tripIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tripIDDataGridViewTextBoxColumn.DataPropertyName = "tripID";
            this.tripIDDataGridViewTextBoxColumn.HeaderText = "tripID";
            this.tripIDDataGridViewTextBoxColumn.Name = "tripIDDataGridViewTextBoxColumn";
            this.tripIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tripIDDataGridViewTextBoxColumn.Width = 57;
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            this.routeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.routeIDDataGridViewTextBoxColumn.DataPropertyName = "routeID";
            this.routeIDDataGridViewTextBoxColumn.HeaderText = "routeID";
            this.routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            this.routeIDDataGridViewTextBoxColumn.Width = 67;
            // 
            // arrivalAdressDataGridViewTextBoxColumn
            // 
            this.arrivalAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.arrivalAdressDataGridViewTextBoxColumn.DataPropertyName = "ArrivalAdress";
            this.arrivalAdressDataGridViewTextBoxColumn.HeaderText = "ArrivalAdress";
            this.arrivalAdressDataGridViewTextBoxColumn.Name = "arrivalAdressDataGridViewTextBoxColumn";
            this.arrivalAdressDataGridViewTextBoxColumn.Width = 93;
            // 
            // departureAdressDataGridViewTextBoxColumn
            // 
            this.departureAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departureAdressDataGridViewTextBoxColumn.DataPropertyName = "DepartureAdress";
            this.departureAdressDataGridViewTextBoxColumn.HeaderText = "DepartureAdress";
            this.departureAdressDataGridViewTextBoxColumn.Name = "departureAdressDataGridViewTextBoxColumn";
            this.departureAdressDataGridViewTextBoxColumn.Width = 111;
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "trip";
            this.tripBindingSource.DataSource = this.autobaseDataSet;
            // 
            // autobaseDataSet
            // 
            this.autobaseDataSet.DataSetName = "AutobaseDataSet";
            this.autobaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GVroute
            // 
            this.GVroute.AutoGenerateColumns = false;
            this.GVroute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVroute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeIDDataGridViewTextBoxColumn1,
            this.cargoDataGridViewTextBoxColumn,
            this.estimatedTimeDataGridViewTextBoxColumn});
            this.GVroute.DataSource = this.routeBindingSource;
            this.GVroute.Location = new System.Drawing.Point(12, 220);
            this.GVroute.Name = "GVroute";
            this.GVroute.Size = new System.Drawing.Size(396, 202);
            this.GVroute.TabIndex = 2;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "route";
            this.routeBindingSource.DataSource = this.autobaseDataSet;
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // routeIDDataGridViewTextBoxColumn1
            // 
            this.routeIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.routeIDDataGridViewTextBoxColumn1.DataPropertyName = "routeID";
            this.routeIDDataGridViewTextBoxColumn1.HeaderText = "routeID";
            this.routeIDDataGridViewTextBoxColumn1.Name = "routeIDDataGridViewTextBoxColumn1";
            this.routeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.routeIDDataGridViewTextBoxColumn1.Width = 21;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.Width = 59;
            // 
            // estimatedTimeDataGridViewTextBoxColumn
            // 
            this.estimatedTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.estimatedTimeDataGridViewTextBoxColumn.DataPropertyName = "EstimatedTime";
            this.estimatedTimeDataGridViewTextBoxColumn.HeaderText = "EstimatedTime";
            this.estimatedTimeDataGridViewTextBoxColumn.Name = "estimatedTimeDataGridViewTextBoxColumn";
            this.estimatedTimeDataGridViewTextBoxColumn.Width = 101;
            // 
            // Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 430);
            this.Controls.Add(this.GVroute);
            this.Controls.Add(this.GVtrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Trip";
            this.Text = "Trip";
            this.Load += new System.EventHandler(this.Trip_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVtrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVroute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView GVtrip;
        private System.Windows.Forms.DataGridView GVroute;
        private AutobaseDataSet autobaseDataSet;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private AutobaseDataSetTableAdapters.tripTableAdapter tripTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private AutobaseDataSetTableAdapters.routeTableAdapter routeTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedTimeDataGridViewTextBoxColumn;
    }
}