using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagementSystemsVBDotNet
{
    public partial class UCDashboardForm : UserControl
    {
        string cs = @"Data Source=BEST-TECHNOLOGY\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDBPrj;Integrated Security=True";

        public UCDashboardForm()
        {
            InitializeComponent();

            this.HandleCreated += UCDashboardForm_HandleCreated;

            TodayIncome();
            YesterdayIncome();
            ThisMonthIncome();
            YearlyIncome();
            TotalIncome();
            //expense
            TodayExpense();
            YesterdayExpense();
            ThisMonthExpense();
            YearlyExpense();
            TotalExpense();

        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            InitializeComponent();
            TodayIncome();
            YesterdayIncome();
            ThisMonthIncome();
            YearlyIncome();
            TotalIncome();
            //expense
            TodayExpense();
            YesterdayExpense();
            ThisMonthExpense();
            YearlyExpense();
            TotalExpense();
        }

        private void UCDashboardForm_HandleCreated(object? sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                ApplyRoundedCorners();
            }));
        }

        public void TodayIncome()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qr = "SELECT SUM(income) AS income FROM tblIncomes WHERE date_income=@date_in AND user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);
                        lblTodayIncome.Text = todayCost.ToString("c");
                    }
                    else
                    {
                        lblTodayIncome.Text = "$0.00";
                    }

                }
            }
        }

        public void YesterdayIncome()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qr = "Select sum(income)as income from tblIncomes where Convert(DATE,date_income)= DATEADD(day,DATEDIFF(day,0,GETDATE()),-1) AND user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal YesterdayCost = Convert.ToDecimal(result);
                        lblYesterdayIncome.Text = YesterdayCost.ToString("c");
                    }
                    else
                    {
                        lblYesterdayIncome.Text = "$0.00";
                    }

                }
            }
        }

        public void ThisMonthIncome()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);
                string qr = "Select sum(income)as income from tblIncomes where date_income>=@startMonth and date_income<=@endMonth AND user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal MonthlyCost = Convert.ToDecimal(result);
                        lblMonthIncome.Text = MonthlyCost.ToString("C");
                    }
                    else
                    {
                        lblMonthIncome.Text = "$0.00";
                    }

                }
            }
        }

        public void YearlyIncome()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string qr = "Select sum(income)as income from tblIncomes where date_income>=@startYear and date_income<=@endYear AND user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal YearCost = Convert.ToDecimal(result);
                        lblYearlyIncome.Text = YearCost.ToString("C");
                    }
                    else
                    {
                        lblYearlyIncome.Text = "$0.00";
                    }

                }
            }
        }

        public void TotalIncome()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string qr = "Select sum(income)as income from tblIncomes WHERE user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Totalincome = Convert.ToDecimal(result);
                        lblTotalIncome.Text = Totalincome.ToString("C");
                    }
                    else
                    {
                        lblTotalIncome.Text = "$0.00";
                    }

                }
            }
        }

        //Expense
        public void TodayExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qr = "select sum(expense)as income from tblExpenses where date_expense=@date_in AND user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);
                        lblTodayExpense.Text = todayCost.ToString("c");
                    }
                    else
                    {
                        lblTodayExpense.Text = "$0.00";
                    }

                }
            }
        }
        public void YesterdayExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qr = "Select sum(expense)as expense from tblExpenses where Convert(DATE,date_expense)= DATEADD(day,DATEDIFF(day,0,GETDATE()),-1) AND user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Yesterdayexpense = Convert.ToDecimal(result);
                        lblYesterdayExpense.Text = Yesterdayexpense.ToString("c");
                    }
                    else
                    {
                        lblYesterdayExpense.Text = "$0.00";
                    }

                }
            }
        }
        public void ThisMonthExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);
                string qr = "Select sum(expense)as expense from tblExpenses where date_expense>=@startMonth and date_expense<=@endMonth AND user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Monthlyexpense = Convert.ToDecimal(result);
                        lblMonthlyExpense.Text = Monthlyexpense.ToString("C");
                    }
                    else
                    {
                        lblMonthlyExpense.Text = "$0.00";
                    }

                }
            }
        }

        public void YearlyExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string qr = "Select sum(expense)as expense from tblExpenses where date_expense>=@startYear and date_expense<=@endYear AND user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Yearexpense = Convert.ToDecimal(result);
                        lblYearlyExpense.Text = Yearexpense.ToString("C");
                    }
                    else
                    {
                        lblYearlyExpense.Text = "$0.00";
                    }

                }
            }
        }

        public void TotalExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string qr = "Select sum(expense)as expense from tblExpenses WHERE user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Totalexpense = Convert.ToDecimal(result);
                        lblTotalExpense.Text = Totalexpense.ToString("C");
                    }
                    else
                    {
                        lblTotalExpense.Text = "$0.00";
                    }

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //--------
    }
}
