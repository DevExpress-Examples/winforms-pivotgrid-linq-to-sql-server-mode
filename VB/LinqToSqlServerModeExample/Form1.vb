Imports DevExpress.Data.Linq
Imports DevExpress.XtraEditors

Namespace LinqToSqlServerModeExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private linqServerModeSource1 As LinqServerModeSource
		Private serverMode As Boolean = False
		Public Sub New()
			InitializeComponent()
			' Create LINQ Server Mode data source.
			linqServerModeSource1 = New LinqServerModeSource With {.ElementType = GetType(Invoice), .KeyExpression = "OrderID"}
			' Create the data context and enable query logging.
			Dim dc As NWindDataContext = New NWindDataContext With {.Log = Console.Out}
			'
			' Specify the queryable source that provides data items.
			linqServerModeSource1.QueryableSource = dc.Invoices
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'nWDataSet.Invoices' table. You can move, or remove it, as needed.
			Me.invoicesTableAdapter.Fill(Me.nWDataSet.Invoices)
			SetPivotGridDataSource()
		End Sub

		Private Sub toggleSwitch1_Toggled(ByVal sender As Object, ByVal e As EventArgs) Handles toggleSwitch1.Toggled
			serverMode = DirectCast(sender, ToggleSwitch).IsOn
			SetPivotGridDataSource()
		End Sub

		Private Sub SetPivotGridDataSource()
			If serverMode Then
				pivotGridControl1.DataSource = linqServerModeSource1
			Else
				pivotGridControl1.DataSource = invoicesBindingSource
			End If
		End Sub
	End Class
End Namespace
