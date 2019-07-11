using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LinqToSqlServerModeExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        bool serverMode = false;
        public Form1()
        {
            InitializeComponent();
            linqServerModeSource1.ElementType = typeof(Invoice);
            linqServerModeSource1.KeyExpression = "OrderID";
            NWindDataContext dc = new NWindDataContext();
            dc.Log = Console.Out;
            linqServerModeSource1.QueryableSource = dc.Invoices;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nWDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.nWDataSet.Invoices);
            SetPivotGridDataSource();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            serverMode = ((ToggleSwitch)sender).IsOn;
            SetPivotGridDataSource();
        }

        private void SetPivotGridDataSource()
        {
            if (serverMode)
                pivotGridControl1.DataSource = linqServerModeSource1;
            else
                pivotGridControl1.DataSource = invoicesBindingSource;
        }
    }
}
