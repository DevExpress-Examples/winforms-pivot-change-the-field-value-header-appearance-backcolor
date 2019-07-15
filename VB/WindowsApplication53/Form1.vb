Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Data
Imports System.Drawing

Namespace CustomDrawFieldValueEventExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler Me.Load, AddressOf Form1_Load
			pivotGridControl1.OptionsView.RowTreeWidth = 150
			PopulateTable()
			pivotGridControl1.RefreshData()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			pivotGridControl1.BestFitColumnArea()
		End Sub

		Private Sub pivotGridControl1_CustomDrawFieldValue(ByVal sender As Object, ByVal e As PivotCustomDrawFieldValueEventArgs) Handles pivotGridControl1.CustomDrawFieldValue
			If e.Area = PivotArea.ColumnArea Then
				e.Appearance.BackColor = Color.GreenYellow
			ElseIf e.Area = PivotArea.RowArea Then
				e.Painter.DrawObject(e.Info)
				e.Painter.DrawIndicator(e.Info)
				e.GraphicsCache.FillRectangle(e.GraphicsCache.GetSolidBrush(Color.FromArgb(50, 0, 0, 200)), e.Bounds)
				e.Handled = True
			End If
		End Sub

		Private Sub PopulateTable()
			Dim myTable As DataTable = dataSet1.Tables("Data")
			myTable.Rows.Add(New Object() { "UK", Date.Today.AddYears(-1), 4, 5 })
			myTable.Rows.Add(New Object() { "UK", Date.Today.AddYears(-1).AddDays(1), 2, 8 })
			myTable.Rows.Add(New Object() { "USA", Date.Today.AddYears(-1), 3, 9 })
			myTable.Rows.Add(New Object() { "USA", Date.Today.AddDays(1).AddYears(-1), 1, 5 })
			myTable.Rows.Add(New Object() { "France", Date.Today.AddYears(-1), 8, 3 })
			myTable.Rows.Add(New Object() { "France", Date.Today.AddDays(1).AddYears(-1), 22 })

			myTable.Rows.Add(New Object() { "UK", Date.Today, 7, 3 })
			myTable.Rows.Add(New Object() { "UK", Date.Today.AddDays(1), 4, 1 })
			myTable.Rows.Add(New Object() { "USA", Date.Today, 12, 6 })
			myTable.Rows.Add(New Object() { "USA", Date.Today.AddDays(1), 14, 7 })
			myTable.Rows.Add(New Object() { "France", Date.Today, 11, 1 })
			myTable.Rows.Add(New Object() { "France", Date.Today.AddDays(1), 10, 3 })
		End Sub
	End Class
End Namespace