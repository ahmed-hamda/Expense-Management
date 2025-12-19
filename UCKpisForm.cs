using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseManagementSystemsVBDotNet
{
    public partial class UCKpisForm : UserControl
    {
        private readonly string cs = @"Data Source=BEST-TECHNOLOGY\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDBPrj;Integrated Security=True";

        public UCKpisForm()
        {
            InitializeComponent();
            SetupChart();
        }

        private void SetupChart()
        {
            chartKpis.Series.Clear();
            chartKpis.ChartAreas.Clear();
            chartKpis.Legends.Clear();

            var area = new ChartArea("Main");
            area.AxisX.IntervalType = DateTimeIntervalType.Days;
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;

            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            // ✅ important: X est une date
            area.AxisX.LabelStyle.Format = "MM-dd";
            area.AxisX.LabelStyle.Angle = -45;

            chartKpis.ChartAreas.Add(area);
            chartKpis.Legends.Add(new Legend("Legend"));

            var sIncome = new Series("Income")
            {
                ChartType = SeriesChartType.Column,   // ✅ bar
                XValueType = ChartValueType.DateTime,
                YAxisType = AxisType.Primary
            };

            var sExpense = new Series("Expense")
            {
                ChartType = SeriesChartType.Column,   // ✅ bar
                XValueType = ChartValueType.DateTime,
                YAxisType = AxisType.Secondary        // ✅ axe droit
            };

            // pour avoir les barres côte à côte (pas empilées)
            sIncome["PointWidth"] = "0.35";
            sExpense["PointWidth"] = "0.35";

            chartKpis.Series.Add(sIncome);
            chartKpis.Series.Add(sExpense);

            // activer l’axe droit
            area.AxisY2.Enabled = AxisEnabled.True;
            area.AxisY2.MajorGrid.Enabled = false;

            area.AxisY.Title = "Income";
            area.AxisY2.Title = "Expense";



        }


        public void LoadKpis()
        {
            try
            {
                // 👉 2 jours avant / 4 jours après aujourd’hui
                DateTime start = DateTime.Today.AddDays(-2);
                DateTime end = DateTime.Today.AddDays(4);

                var incomeByDay = GetSumByDay("tblIncomes", "date_income", "income", start, end);
                var expenseByDay = GetSumByDay("tblExpenses", "date_expense", "expense", start, end);

                var sIncome = chartKpis.Series["Income"];
                var sExpense = chartKpis.Series["Expense"];
                sIncome.Points.Clear();
                sExpense.Points.Clear();

                for (int i = 0; i < 7; i++)
                {
                    DateTime d = start.AddDays(i).Date;

                    decimal inc = incomeByDay.TryGetValue(d, out var v1) ? v1 : 0m;
                    decimal exp = expenseByDay.TryGetValue(d, out var v2) ? v2 : 0m;

                    // Income (bar normale)
                    chartKpis.Series["Income"].Points.AddXY(d, inc);

                    // Expense (décalage léger à droite pour être côte à côte)
                    chartKpis.Series["Expense"].Points.AddXY(d.AddHours(12), exp);

                }

                // Fixer l’axe X exactement sur ces 7 jours
                var axisX = chartKpis.ChartAreas["Main"].AxisX;
                axisX.Minimum = start.ToOADate();
                axisX.Maximum = end.AddDays(0.999).ToOADate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "KPIs Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private Dictionary<DateTime, decimal> GetSumByDay(
    string table, string dateCol, string amountCol,
    DateTime start, DateTime end)
        {
            var result = new Dictionary<DateTime, decimal>();

            string sql = $@"
SELECT CONVERT(date, {dateCol}) AS d,
       SUM(CAST({amountCol} AS decimal(18,2))) AS total
FROM {table}
WHERE {dateCol} >= @start AND {dateCol} < DATEADD(day, 1, @end)
  AND user_id = @uid
GROUP BY CONVERT(date, {dateCol})
ORDER BY d;";

            using var con = new SqlConnection(cs);
            using var cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
            con.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                DateTime d = Convert.ToDateTime(r["d"]).Date;
                decimal total = r["total"] == DBNull.Value ? 0m : Convert.ToDecimal(r["total"]);
                result[d] = total;
            }

            return result;
        }

        private void chartKpis_Click(object sender, EventArgs e)
        {

        }
    }
}
