Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace LinqToSqlServerModeExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private serverMode As Boolean = False
		Public Sub New()
			InitializeComponent()
			linqServerModeSource1.ElementType = GetType(Invoice)
			linqServerModeSource1.KeyExpression = "OrderID"
			Dim dc As New NWindDataContext()
			dc.Log = Console.Out
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
