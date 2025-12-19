using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagementSystemsVBDotNet
{
    internal class IncomeData
    {
        string cs = @"Data Source=BEST-TECHNOLOGY\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDBPrj;Integrated Security=True";
        public int ID { set; get; }
        public string Category { set; get; }
        public string Item { set; get; }
        public string Income { set; get; }
        public string Description { set; get; }
        public string Date { set; get; }

        public List<User> users { set; get; } = new List<User>();

        public List<IncomeData> IncomeListData()
        {
            List<IncomeData> listData = new List<IncomeData>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string selectData = "SELECT * FROM tblIncomes WHERE user_id = @uid";
                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();
                        iData.ID = (int)reader["id"];
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Income = reader["income"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.Date = ((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");
                        //cData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");
                        listData.Add(iData);
                        iData.users = [];

                    }
                }
            }
            return listData;    

        }
    }
}
