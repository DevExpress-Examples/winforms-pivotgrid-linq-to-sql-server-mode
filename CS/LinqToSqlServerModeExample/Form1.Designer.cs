namespace LinqToSqlServerModeExample
{
    partial class Form1
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDateYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDateMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nWDataSet = new LinqToSqlServerModeExample.NWDataSet();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.invoicesTableAdapter = new LinqToSqlServerModeExample.NWDataSetTableAdapters.InvoicesTableAdapter();
            this.linqServerModeSource1 = new DevExpress.Data.Linq.LinqServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountry,
            this.fieldCity,
            this.fieldOrderDateYear,
            this.fieldExtendedPrice,
            this.fieldOrderDateMonth});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 49);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(800, 401);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            this.fieldCountry.FieldName = "Country";
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldCity
            // 
            this.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCity.AreaIndex = 1;
            this.fieldCity.Caption = "City";
            this.fieldCity.FieldName = "City";
            this.fieldCity.Name = "fieldCity";
            // 
            // fieldOrderDateYear
            // 
            this.fieldOrderDateYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDateYear.AreaIndex = 0;
            this.fieldOrderDateYear.Caption = "Order Year";
            this.fieldOrderDateYear.FieldName = "OrderDate";
            this.fieldOrderDateYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDateYear.Name = "fieldOrderDateYear";
            this.fieldOrderDateYear.UnboundFieldName = "fldYear";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.FieldName = "ExtendedPrice";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldOrderDateMonth
            // 
            this.fieldOrderDateMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDateMonth.AreaIndex = 1;
            this.fieldOrderDateMonth.Caption = "Order Month";
            this.fieldOrderDateMonth.FieldName = "OrderDate";
            this.fieldOrderDateMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderDateMonth.Name = "fieldOrderDateMonth";
            this.fieldOrderDateMonth.UnboundFieldName = "fldMonth";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.nWDataSet;
            // 
            // nWDataSet
            // 
            this.nWDataSet.DataSetName = "NWDataSet";
            this.nWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.toggleSwitch1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 49);
            this.panelControl1.TabIndex = 1;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(12, 12);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Server Mode Off";
            this.toggleSwitch1.Properties.OnText = "Server Mode On";
            this.toggleSwitch1.Size = new System.Drawing.Size(158, 18);
            this.toggleSwitch1.TabIndex = 1;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "LINQ to SQL Server Mode Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private LinqToSqlServerModeExample.NWDataSet nWDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private LinqToSqlServerModeExample.NWDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDateYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDateMonth;
        private DevExpress.Data.Linq.LinqServerModeSource linqServerModeSource1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}

