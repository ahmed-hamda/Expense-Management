using System;
using System.Windows.Forms;

namespace ExpenseManagementSystemsVBDotNet
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            displayUsername();
            ActivateButton(btnDashboard);

            // Charger le Dashboard UserControl
            UCDashboardForm uc_Das = new UCDashboardForm();
            LoadFormInPanel(uc_Das);
            uc_Das.refreshData();
        }

        public void displayUsername()
        {
            string getUsersname = Form1.username;
            lblDisplayName.Text = getUsersname.ToUpper();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginform = new Form1();
                loginform.Show();
                this.Hide();
            }
        }

        private void LoadFormInPanel(UserControl selectedForm)
        {
            panel3.Controls.Clear();
            selectedForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(selectedForm);
            selectedForm.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDashboard);

            UCDashboardForm uc_Das = new UCDashboardForm();
            LoadFormInPanel(uc_Das);
            uc_Das.refreshData();
        }

        private void btnKpis_Click(object sender, EventArgs e)
        {
            ActivateButton(btnKpis);
            UCKpisForm uc_kpis = new UCKpisForm();
            LoadFormInPanel(uc_kpis);
            uc_kpis.LoadKpis();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCategory);
            UCCategoryForm uc_Category = new UCCategoryForm();
            LoadFormInPanel(uc_Category);
            uc_Category.refreshData();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            ActivateButton(btnIncome);
            UCIncomeForm incomeForm = new UCIncomeForm();
            LoadFormInPanel(incomeForm);
            incomeForm.refreshData();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ActivateButton(btnExpenses);
            UCExpenseForm uc_exp = new UCExpenseForm();
            LoadFormInPanel(uc_exp);
            uc_exp.refreshData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ucDashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ActivateButton(Button btn)
        {
            ResetMenuButtons();
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }
        private void ResetMenuButtons()
        {
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is Button btn && btn != btnLogout)
                {
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font(btn.Font, FontStyle.Regular);

                }
            }
        }
    }
}
