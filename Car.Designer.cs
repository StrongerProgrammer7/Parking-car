
namespace Autobase
{
    partial class Car
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
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GVcar = new System.Windows.Forms.DataGridView();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumbersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobaseDataSet = new Autobase.AutobaseDataSet();
            this.carTableAdapter = new Autobase.AutobaseDataSetTableAdapters.carTableAdapter();
            this.GVbrand = new System.Windows.Forms.DataGridView();
            this.brandIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horsepowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new Autobase.AutobaseDataSetTableAdapters.brandTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVbrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
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
            this.carToolStripMenuItem,
            this.brandToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.deleteToolStripMenuItem.Text = "Delete...";
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.carToolStripMenuItem.Text = "car";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.brandToolStripMenuItem.Text = "brand";
            this.brandToolStripMenuItem.Click += new System.EventHandler(this.brandToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.closeToolStripMenuItem.Text = "Cancel";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // GVcar
            // 
            this.GVcar.AutoGenerateColumns = false;
            this.GVcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVcar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.brandIDDataGridViewTextBoxColumn,
            this.carNumbersDataGridViewTextBoxColumn});
            this.GVcar.DataSource = this.carBindingSource;
            this.GVcar.Location = new System.Drawing.Point(12, 27);
            this.GVcar.Name = "GVcar";
            this.GVcar.Size = new System.Drawing.Size(286, 316);
            this.GVcar.TabIndex = 1;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "carID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "#";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.carIDDataGridViewTextBoxColumn.Width = 39;
            // 
            // brandIDDataGridViewTextBoxColumn
            // 
            this.brandIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brandIDDataGridViewTextBoxColumn.DataPropertyName = "brandID";
            this.brandIDDataGridViewTextBoxColumn.HeaderText = "brandID";
            this.brandIDDataGridViewTextBoxColumn.Name = "brandIDDataGridViewTextBoxColumn";
            this.brandIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // carNumbersDataGridViewTextBoxColumn
            // 
            this.carNumbersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.carNumbersDataGridViewTextBoxColumn.DataPropertyName = "CarNumbers";
            this.carNumbersDataGridViewTextBoxColumn.HeaderText = "CarNumbers";
            this.carNumbersDataGridViewTextBoxColumn.Name = "carNumbersDataGridViewTextBoxColumn";
            this.carNumbersDataGridViewTextBoxColumn.Width = 90;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.autobaseDataSet;
            // 
            // autobaseDataSet
            // 
            this.autobaseDataSet.DataSetName = "AutobaseDataSet";
            this.autobaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // GVbrand
            // 
            this.GVbrand.AutoGenerateColumns = false;
            this.GVbrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVbrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandIDDataGridViewTextBoxColumn1,
            this.colourDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.dateofbuyDataGridViewTextBoxColumn,
            this.loadCapacityDataGridViewTextBoxColumn,
            this.horsepowerDataGridViewTextBoxColumn});
            this.GVbrand.DataSource = this.brandBindingSource;
            this.GVbrand.Location = new System.Drawing.Point(304, 27);
            this.GVbrand.Name = "GVbrand";
            this.GVbrand.Size = new System.Drawing.Size(557, 316);
            this.GVbrand.TabIndex = 2;
            // 
            // brandIDDataGridViewTextBoxColumn1
            // 
            this.brandIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brandIDDataGridViewTextBoxColumn1.DataPropertyName = "brandID";
            this.brandIDDataGridViewTextBoxColumn1.HeaderText = "brandID";
            this.brandIDDataGridViewTextBoxColumn1.Name = "brandIDDataGridViewTextBoxColumn1";
            this.brandIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.brandIDDataGridViewTextBoxColumn1.Width = 70;
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            this.colourDataGridViewTextBoxColumn.Width = 61;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 60;
            // 
            // dateofbuyDataGridViewTextBoxColumn
            // 
            this.dateofbuyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateofbuyDataGridViewTextBoxColumn.DataPropertyName = "dateofbuy";
            this.dateofbuyDataGridViewTextBoxColumn.HeaderText = "dateofbuy";
            this.dateofbuyDataGridViewTextBoxColumn.Name = "dateofbuyDataGridViewTextBoxColumn";
            this.dateofbuyDataGridViewTextBoxColumn.Width = 79;
            // 
            // loadCapacityDataGridViewTextBoxColumn
            // 
            this.loadCapacityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loadCapacityDataGridViewTextBoxColumn.DataPropertyName = "LoadCapacity";
            this.loadCapacityDataGridViewTextBoxColumn.HeaderText = "LoadCapacity";
            this.loadCapacityDataGridViewTextBoxColumn.Name = "loadCapacityDataGridViewTextBoxColumn";
            this.loadCapacityDataGridViewTextBoxColumn.Width = 97;
            // 
            // horsepowerDataGridViewTextBoxColumn
            // 
            this.horsepowerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horsepowerDataGridViewTextBoxColumn.DataPropertyName = "horsepower";
            this.horsepowerDataGridViewTextBoxColumn.HeaderText = "horsepower";
            this.horsepowerDataGridViewTextBoxColumn.Name = "horsepowerDataGridViewTextBoxColumn";
            this.horsepowerDataGridViewTextBoxColumn.Width = 87;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.autobaseDataSet;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 355);
            this.Controls.Add(this.GVbrand);
            this.Controls.Add(this.GVcar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVbrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView GVcar;
        private AutobaseDataSet autobaseDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private AutobaseDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridView GVbrand;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private AutobaseDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horsepowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
    }
}