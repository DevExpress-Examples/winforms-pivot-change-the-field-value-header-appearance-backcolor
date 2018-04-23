Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication53
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            PopulateTable()
            pivotGridControl1.RefreshData()
            pivotGridControl1.BestFitColumnArea()

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

		' #Region "#CustomDrawFieldValueEvent"
        Private Sub pivotGridControl1_CustomDrawFieldValue(ByVal sender As Object,
            ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventArgs) Handles pivotGridControl1.CustomDrawFieldValue
            If e.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea Then
                Dim rect As Rectangle = e.Bounds
                ControlPaint.DrawBorder3D(e.Graphics, e.Bounds)
                Dim brush As Brush = e.GraphicsCache.GetSolidBrush(Color.LightYellow)
                rect.Inflate(-1, -1)
                e.Graphics.FillRectangle(brush, rect)
                e.Appearance.DrawString(e.GraphicsCache, e.Info.Caption, e.Info.CaptionRect)
                e.Painter.DrawIndicator(e.Info)
                e.Handled = True
            ElseIf e.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea Then
                e.Painter.DrawObject(e.Info)
                e.Painter.DrawIndicator(e.Info)
                e.Graphics.FillRectangle(e.GraphicsCache.GetSolidBrush(Color.FromArgb(50, 0, 0, 200)), e.Bounds)
                e.Handled = True
            End If
        End Sub
		' #End Region ' #CustomDrawFieldValueEvent
    End Class
End Namespace