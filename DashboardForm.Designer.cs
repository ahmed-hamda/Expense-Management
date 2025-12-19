using System.Drawing;
using System.Windows.Forms;

namespace ExpenseManagementSystemsVBDotNet
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            picExit = new PictureBox();
            panel2 = new Panel();
            btnLogout = new Button();
            btnExpenses = new Button();
            btnIncome = new Button();
            btnCategory = new Button();
            btnKpis = new Button();
            btnDashboard = new Button();
            lblDisplayName = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ucDashboardForm1 = new UCDashboardForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(picExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 61);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.programmer;
            pictureBox2.Location = new Point(547, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(592, 17);
            label1.Name = "label1";
            label1.Size = new Size(289, 25);
            label1.TabIndex = 3;
            label1.Text = "Expense Management Systems ";
            // 
            // picExit
            // 
            picExit.Cursor = Cursors.Hand;
            picExit.Image = Properties.Resources.close;
            picExit.Location = new Point(1406, 8);
            picExit.Margin = new Padding(3, 4, 3, 4);
            picExit.Name = "picExit";
            picExit.Size = new Size(33, 35);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 2;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnExpenses);
            panel2.Controls.Add(btnIncome);
            panel2.Controls.Add(btnCategory);
            panel2.Controls.Add(btnKpis);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(lblDisplayName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 61);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 847);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Red;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(23, 761);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(175, 52);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "    LogOut";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.Black;
            btnExpenses.Cursor = Cursors.Hand;
            btnExpenses.FlatAppearance.MouseDownBackColor = Color.Black;
            btnExpenses.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnExpenses.Location = new Point(23, 500);
            btnExpenses.Margin = new Padding(3, 4, 3, 4);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(175, 52);
            btnExpenses.TabIndex = 8;
            btnExpenses.Text = "💸 Expense";
            btnExpenses.UseVisualStyleBackColor = false;
            btnExpenses.Click += btnExpenses_Click;
            // 
            // btnIncome
            // 
            btnIncome.BackColor = Color.Black;
            btnIncome.Cursor = Cursors.Hand;
            btnIncome.FlatAppearance.MouseDownBackColor = Color.Black;
            btnIncome.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnIncome.Location = new Point(23, 438);
            btnIncome.Margin = new Padding(3, 4, 3, 4);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(175, 52);
            btnIncome.TabIndex = 7;
            btnIncome.Text = "💰 Income";
            btnIncome.UseVisualStyleBackColor = false;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.Black;
            btnCategory.Cursor = Cursors.Hand;
            btnCategory.FlatAppearance.MouseDownBackColor = Color.Black;
            btnCategory.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnCategory.Location = new Point(23, 343);
            btnCategory.Margin = new Padding(3, 4, 3, 4);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(175, 52);
            btnCategory.TabIndex = 6;
            btnCategory.Text = "📁 Category";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnKpis
            // 
            btnKpis.BackColor = Color.Black;
            btnKpis.Cursor = Cursors.Hand;
            btnKpis.FlatAppearance.MouseDownBackColor = Color.Black;
            btnKpis.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnKpis.Location = new Point(23, 281);
            btnKpis.Margin = new Padding(3, 4, 3, 4);
            btnKpis.Name = "btnKpis";
            btnKpis.Size = new Size(175, 52);
            btnKpis.TabIndex = 5;
            btnKpis.Text = "📈 KPIs Stats";
            btnKpis.UseVisualStyleBackColor = false;
            btnKpis.Click += btnKpis_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.Black;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnDashboard.Location = new Point(23, 220);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(175, 52);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lblDisplayName.ForeColor = Color.Yellow;
            lblDisplayName.Location = new Point(111, 136);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(59, 23);
            lblDisplayName.TabIndex = 4;
            lblDisplayName.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 136);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 3;
            label5.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(ucDashboardForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(229, 61);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1216, 847);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // ucDashboardForm1
            // 
            ucDashboardForm1.BackColor = SystemColors.InactiveCaption;
            ucDashboardForm1.Location = new Point(7, 47);
            ucDashboardForm1.Margin = new Padding(3, 5, 3, 5);
            ucDashboardForm1.Name = "ucDashboardForm1";
            ucDashboardForm1.Size = new Size(1216, 847);
            ucDashboardForm1.TabIndex = 0;
            ucDashboardForm1.Load += ucDashboardForm1_Load;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox picExit;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label lblDisplayName;
        private Button btnDashboard;
        private Button btnKpis;
        private Button btnLogout;
        private Button btnExpenses;
        private Button btnIncome;
        private Button btnCategory;
        private Panel panel3;
        private UCDashboardForm ucDashboardForm1;
    }
}
