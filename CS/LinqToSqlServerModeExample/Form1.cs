using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using System;

namespace LinqToSqlServerModeExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        LinqServerModeSource linqServerModeSource1;
        bool serverMode = false;
        public Form1()
        {
            InitializeComponent();
            // Create LINQ Server Mode data source.
            linqServerModeSource1 = new LinqServerModeSource
            {
                ElementType = typeof(Invoice),
                KeyExpression = "OrderID"
            };
            // Create the data context and enable query logging.
            NWindDataContext dc = new NWindDataContext { Log = Console.Out };
            // Specify the queryable source that provides data items.
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
