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
    internal class CategoryData
    {
        string cs = @"Data Source=BEST-TECHNOLOGY\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDBPrj;Integrated Security=True";
        public int ID { set; get; }
        public string Category { set; get; }
        public string Type { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<User> users { set; get; } = new List<User>();


        public List<CategoryData> categoryListData()
        {
            List<CategoryData> listData = new List<CategoryData>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string selectData = "SELECT * FROM tblCategories WHERE user_id=@uid";
                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    cmd.Parameters.AddWithValue("@uid", Form1.CurrentUserId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoryData cData = new CategoryData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");
                        listData.Add(cData);
                        cData.users = [];

                    }
                }
            }
            return listData;

        }
    }
}
