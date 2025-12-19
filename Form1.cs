using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;

namespace ExpenseManagementSystemsVBDotNet
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=BEST-TECHNOLOGY\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDBPrj;Integrated Security=True");
        public static int CurrentUserId;
        public static string username;

        public Form1()
        {
            InitializeComponent();
        }
        public bool checkConnection()
        {
            return (con.State == ConnectionState.Closed) ? true : false;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            RegisterForm registerfrm = new RegisterForm();
            registerfrm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = !isChecked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("invalid username and password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string hashedPassword = ComputeSha256Hash(txtPassword.Text.Trim());
                    string qr = "select id, username from tblUsers where username =@user and password=@pass";
                    using (SqlCommand cmd = new SqlCommand(qr, con))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", hashedPassword);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            CurrentUserId = Convert.ToInt32(dt.Rows[0]["id"]);
                            username = dt.Rows[0]["username"].ToString();
                            //MessageBox.Show("Login Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DashboardForm dfrm = new DashboardForm();
                            dfrm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // convert to hex
                }
                return builder.ToString();
            }
        }
    }
}
