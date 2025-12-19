using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace ExpenseManagementSystemsVBDotNet
{
    internal class ExpenseData
    {
        string cs = @"Data Source=BEST-TECHNOLOGY\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDBPrj;Integrated Security=True";
        public int ID { set; get; }
        public string Category { set; get; }
        public string Item { set; get; }
        public string Expense { set; get; }
        public string Description { set; get; }
        public string Date { set; get; }

        public List<User> users { set; get; } = new List<User>(); 

        public List<ExpenseData> ExpenseListData()
        {
            List<ExpenseData> listData = new List<ExpenseData>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string selectData = "SELECT * FROM tblExpenses WHERE user_id = @uid";
                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ExpenseData iData = new ExpenseData();
                        iData.ID = (int)reader["id"];
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Expense = reader["expense"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.Date = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");
                        listData.Add(iData);
                        iData.users = [];

                    }
                }
              
            }
            return listData;

        }
    }
}
