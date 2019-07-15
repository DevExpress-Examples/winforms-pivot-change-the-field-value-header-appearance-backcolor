using DevExpress.XtraPivotGrid;
using System;
using System.Data;
using System.Drawing;

namespace CustomDrawFieldValueEventExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1() {
            InitializeComponent();
            this.Load += Form1_Load;
            pivotGridControl1.OptionsView.RowTreeWidth = 150;
            PopulateTable();
            pivotGridControl1.RefreshData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pivotGridControl1.BestFitColumnArea();
        }

        private void pivotGridControl1_CustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e)
        {
            if (e.Area == PivotArea.ColumnArea)
            {
                e.Appearance.BackColor = Color.GreenYellow;
            }
            else if (e.Area == PivotArea.RowArea)
            {
                e.Painter.DrawObject(e.Info);
                e.Painter.DrawIndicator(e.Info);
                e.GraphicsCache.FillRectangle(e.GraphicsCache.GetSolidBrush(Color.FromArgb(50, 0, 0, 200)), e.Bounds);
                e.Handled = true;
            }
        }

        private void PopulateTable() {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] { "UK", DateTime.Today.AddYears(-1), 4, 5 });
            myTable.Rows.Add(new object[] { "UK", DateTime.Today.AddYears(-1).AddDays(1), 2, 8 });
            myTable.Rows.Add(new object[] { "USA", DateTime.Today.AddYears(-1), 3, 9 });
            myTable.Rows.Add(new object[] { "USA", DateTime.Today.AddDays(1).AddYears(-1), 1, 5 });
            myTable.Rows.Add(new object[] { "France", DateTime.Today.AddYears(-1), 8, 3 });
            myTable.Rows.Add(new object[] { "France", DateTime.Today.AddDays(1).AddYears(-1), 22 });

            myTable.Rows.Add(new object[] { "UK", DateTime.Today, 7, 3 });
            myTable.Rows.Add(new object[] { "UK", DateTime.Today.AddDays(1), 4, 1 });
            myTable.Rows.Add(new object[] { "USA", DateTime.Today, 12, 6 });
            myTable.Rows.Add(new object[] { "USA", DateTime.Today.AddDays(1), 14, 7 });
            myTable.Rows.Add(new object[] { "France", DateTime.Today, 11, 1 });
            myTable.Rows.Add(new object[] { "France", DateTime.Today.AddDays(1), 10, 3 });
        }
    }
}