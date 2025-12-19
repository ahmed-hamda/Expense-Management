using System.Drawing.Drawing2D;

namespace ExpenseManagementSystemsVBDotNet
{
    partial class UCDashboardForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void SetPanelRadius(Panel panel, int radius)
        {
            Rectangle rect = panel.ClientRectangle;
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label17 = new Label();
            lblYearlyIncome = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label16 = new Label();
            label15 = new Label();
            lblMonthIncome = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label14 = new Label();
            lblYesterdayIncome = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label13 = new Label();
            lblTodayIncome = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            label22 = new Label();
            lblYearlyExpense = new Label();
            pictureBox8 = new PictureBox();
            panel8 = new Panel();
            label21 = new Label();
            label20 = new Label();
            lblMonthlyExpense = new Label();
            pictureBox7 = new PictureBox();
            panel9 = new Panel();
            label19 = new Label();
            lblYesterdayExpense = new Label();
            pictureBox6 = new PictureBox();
            panel10 = new Panel();
            label18 = new Label();
            lblTodayExpense = new Label();
            pictureBox5 = new PictureBox();
            panel11 = new Panel();
            panel13 = new Panel();
            label23 = new Label();
            lblTotalIncome = new Label();
            pictureBox9 = new PictureBox();
            label3 = new Label();
            panel12 = new Panel();
            panel14 = new Panel();
            label25 = new Label();
            lblTotalExpense = new Label();
            pictureBox10 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel11.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel12.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(16, 37);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 244);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 3;
            label1.Text = "Income's Record";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(label17);
            panel5.Controls.Add(lblYearlyIncome);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(894, 64);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(261, 172);
            panel5.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.ForeColor = Color.Yellow;
            label17.Location = new Point(49, 111);
            label17.Name = "label17";
            label17.Size = new Size(172, 28);
            label17.TabIndex = 6;
            label17.Text = "This Year Income";
            // 
            // lblYearlyIncome
            // 
            lblYearlyIncome.AutoSize = true;
            lblYearlyIncome.BorderStyle = BorderStyle.FixedSingle;
            lblYearlyIncome.Font = new Font("Corbel", 10F, FontStyle.Bold);
            lblYearlyIncome.ForeColor = Color.White;
            lblYearlyIncome.Location = new Point(96, 16);
            lblYearlyIncome.Name = "lblYearlyIncome";
            lblYearlyIncome.Size = new Size(21, 23);
            lblYearlyIncome.TabIndex = 5;
            lblYearlyIncome.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.yearlyIncome;
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(lblMonthIncome);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(608, 64);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(261, 172);
            panel4.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.ForeColor = Color.Yellow;
            label16.Location = new Point(51, 111);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 7;
            label16.Text = "This Month Income";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = Color.Yellow;
            label15.Location = new Point(311, 88);
            label15.Name = "label15";
            label15.Size = new Size(157, 28);
            label15.TabIndex = 6;
            label15.Text = "Today's Income";
            // 
            // lblMonthIncome
            // 
            lblMonthIncome.AutoSize = true;
            lblMonthIncome.BorderStyle = BorderStyle.FixedSingle;
            lblMonthIncome.Font = new Font("Corbel", 10F, FontStyle.Bold);
            lblMonthIncome.ForeColor = Color.White;
            lblMonthIncome.Location = new Point(91, 16);
            lblMonthIncome.Name = "lblMonthIncome";
            lblMonthIncome.Size = new Size(21, 23);
            lblMonthIncome.TabIndex = 5;
            lblMonthIncome.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.yearly_expense;
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(lblYesterdayIncome);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(312, 64);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 172);
            panel3.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = Color.Yellow;
            label14.Location = new Point(57, 111);
            label14.Name = "label14";
            label14.Size = new Size(192, 28);
            label14.TabIndex = 6;
            label14.Text = "Yesterday's Income";
            // 
            // lblYesterdayIncome
            // 
            lblYesterdayIncome.AutoSize = true;
            lblYesterdayIncome.BorderStyle = BorderStyle.FixedSingle;
            lblYesterdayIncome.Font = new Font("Corbel", 10F, FontStyle.Bold);
            lblYesterdayIncome.ForeColor = Color.White;
            lblYesterdayIncome.Location = new Point(89, 16);
            lblYesterdayIncome.Name = "lblYesterdayIncome";
            lblYesterdayIncome.Size = new Size(21, 23);
            lblYesterdayIncome.TabIndex = 5;
            lblYesterdayIncome.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.yesterday_income;
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(lblTodayIncome);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(17, 64);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 172);
            panel2.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = Color.Yellow;
            label13.Location = new Point(78, 111);
            label13.Name = "label13";
            label13.Size = new Size(157, 28);
            label13.TabIndex = 5;
            label13.Text = "Today's Income";
            // 
            // lblTodayIncome
            // 
            lblTodayIncome.AutoSize = true;
            lblTodayIncome.Font = new Font("Corbel", 10F, FontStyle.Bold);
            lblTodayIncome.ForeColor = Color.WhiteSmoke;
            lblTodayIncome.Location = new Point(97, 16);
            lblTodayIncome.Name = "lblTodayIncome";
            lblTodayIncome.Size = new Size(19, 21);
            lblTodayIncome.TabIndex = 4;
            lblTodayIncome.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.todayincome;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel10);
            panel6.Location = new Point(17, 296);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1183, 244);
            panel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(17, 32);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 4;
            label2.Text = "Expense's Record";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Controls.Add(label22);
            panel7.Controls.Add(lblYearlyExpense);
            panel7.Controls.Add(pictureBox8);
            panel7.Location = new Point(894, 64);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(261, 172);
            panel7.TabIndex = 2;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label22.ForeColor = Color.Yellow;
            label22.Location = new Point(63, 107);
            label22.Name = "label22";
            label22.Size = new Size(189, 28);
            label22.TabIndex = 6;
            label22.Text = "This Year Expenses";
            // 
            // lblYearlyExpense
            // 
            lblYearlyExpense.AutoSize = true;
            lblYearlyExpense.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblYearlyExpense.ForeColor = Color.White;
            lblYearlyExpense.Location = new Point(89, 17);
            lblYearlyExpense.Name = "lblYearlyExpense";
            lblYearlyExpense.Size = new Size(18, 20);
            lblYearlyExpense.TabIndex = 5;
            lblYearlyExpense.Text = "0";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.yearly_expense1;
            pictureBox8.Location = new Point(3, 4);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(69, 80);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Controls.Add(label21);
            panel8.Controls.Add(label20);
            panel8.Controls.Add(lblMonthlyExpense);
            panel8.Controls.Add(pictureBox7);
            panel8.Location = new Point(608, 64);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(261, 172);
            panel8.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label21.ForeColor = Color.Yellow;
            label21.Location = new Point(50, 107);
            label21.Name = "label21";
            label21.Size = new Size(212, 28);
            label21.TabIndex = 6;
            label21.Text = "This Month Expenses";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label20.ForeColor = Color.Yellow;
            label20.Location = new Point(349, 107);
            label20.Name = "label20";
            label20.Size = new Size(157, 28);
            label20.TabIndex = 6;
            label20.Text = "Today's Income";
            // 
            // lblMonthlyExpense
            // 
            lblMonthlyExpense.AutoSize = true;
            lblMonthlyExpense.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblMonthlyExpense.ForeColor = Color.White;
            lblMonthlyExpense.Location = new Point(90, 17);
            lblMonthlyExpense.Name = "lblMonthlyExpense";
            lblMonthlyExpense.Size = new Size(18, 20);
            lblMonthlyExpense.TabIndex = 5;
            lblMonthlyExpense.Text = "0";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.budget;
            pictureBox7.Location = new Point(3, 4);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(69, 80);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Controls.Add(label19);
            panel9.Controls.Add(lblYesterdayExpense);
            panel9.Controls.Add(pictureBox6);
            panel9.Location = new Point(312, 64);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(261, 172);
            panel9.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label19.ForeColor = Color.Yellow;
            label19.Location = new Point(46, 107);
            label19.Name = "label19";
            label19.Size = new Size(209, 28);
            label19.TabIndex = 6;
            label19.Text = "Yesterday's Expenses";
            // 
            // lblYesterdayExpense
            // 
            lblYesterdayExpense.AutoSize = true;
            lblYesterdayExpense.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblYesterdayExpense.ForeColor = Color.White;
            lblYesterdayExpense.Location = new Point(88, 17);
            lblYesterdayExpense.Name = "lblYesterdayExpense";
            lblYesterdayExpense.Size = new Size(18, 20);
            lblYesterdayExpense.TabIndex = 5;
            lblYesterdayExpense.Text = "0";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.poor;
            pictureBox6.Location = new Point(3, 4);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(69, 80);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Controls.Add(label18);
            panel10.Controls.Add(lblTodayExpense);
            panel10.Controls.Add(pictureBox5);
            panel10.Location = new Point(17, 64);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(261, 172);
            panel10.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.ForeColor = Color.Yellow;
            label18.Location = new Point(61, 107);
            label18.Name = "label18";
            label18.Size = new Size(174, 28);
            label18.TabIndex = 6;
            label18.Text = "Today's Expenses";
            // 
            // lblTodayExpense
            // 
            lblTodayExpense.AutoSize = true;
            lblTodayExpense.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblTodayExpense.ForeColor = Color.White;
            lblTodayExpense.Location = new Point(81, 17);
            lblTodayExpense.Name = "lblTodayExpense";
            lblTodayExpense.Size = new Size(18, 20);
            lblTodayExpense.TabIndex = 5;
            lblTodayExpense.Text = "0";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.accounting;
            pictureBox5.Location = new Point(3, 4);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(69, 80);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(label3);
            panel11.Location = new Point(17, 577);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(573, 207);
            panel11.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Controls.Add(label23);
            panel13.Controls.Add(lblTotalIncome);
            panel13.Controls.Add(pictureBox9);
            panel13.Location = new Point(16, 59);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(350, 132);
            panel13.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label23.ForeColor = Color.Yellow;
            label23.Location = new Point(82, 79);
            label23.Name = "label23";
            label23.Size = new Size(134, 28);
            label23.TabIndex = 5;
            label23.Text = "Total Income";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Courier New", 15F, FontStyle.Bold);
            lblTotalIncome.ForeColor = Color.White;
            lblTotalIncome.Location = new Point(97, 24);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(28, 29);
            lblTotalIncome.TabIndex = 4;
            lblTotalIncome.Text = "0";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.totalincome;
            pictureBox9.Location = new Point(7, 24);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(69, 80);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 4;
            label3.Text = "Total Income";
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(panel14);
            panel12.Controls.Add(label4);
            panel12.Location = new Point(613, 577);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(573, 207);
            panel12.TabIndex = 3;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Controls.Add(label25);
            panel14.Controls.Add(lblTotalExpense);
            panel14.Controls.Add(pictureBox10);
            panel14.Location = new Point(21, 59);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(350, 132);
            panel14.TabIndex = 6;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label25.ForeColor = Color.Yellow;
            label25.Location = new Point(82, 79);
            label25.Name = "label25";
            label25.Size = new Size(142, 28);
            label25.TabIndex = 5;
            label25.Text = "Total Expense";
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.Font = new Font("Courier New", 15F, FontStyle.Bold);
            lblTotalExpense.ForeColor = Color.White;
            lblTotalExpense.Location = new Point(97, 24);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(28, 29);
            lblTotalExpense.TabIndex = 4;
            lblTotalExpense.Text = "0";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.totalexpense;
            pictureBox10.Location = new Point(7, 24);
            pictureBox10.Margin = new Padding(3, 4, 3, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(69, 80);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(11, 12);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 4;
            label4.Text = "Total Expense";
            // 
            // UCDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCDashboardForm";
            Size = new Size(1216, 847);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
        }
        private void ApplyRoundedCorners()
        {
            int radius = 24;
            ApplyRadiusRecursively(this, radius);
        }

        private void ApplyRadiusRecursively(Control control, int radius)
        {
            if (control is Panel panel)
            {
                SetPanelRadius(panel, radius);

                panel.Resize -= Panel_Resize;
                panel.Resize += Panel_Resize;
            }

            foreach (Control child in control.Controls)
                ApplyRadiusRecursively(child, radius);
        }

        private void Panel_Resize(object? sender, EventArgs e)
        {
            if (sender is Panel panel)
                SetPanelRadius(panel, 24);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Label label1;
        private Label label2;
        private Panel panel11;
        private Panel panel12;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label lblYearlyIncome;
        private Label lblMonthIncome;
        private Label lblYesterdayIncome;
        private Label lblTodayIncome;
        private Label lblYesterdayExpense;
        private Label lblTodayExpense;
        private Label lblYearlyExpense;
        private Label lblMonthlyExpense;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Panel panel13;
        private Label label23;
        private Label lblTotalIncome;
        private PictureBox pictureBox9;
        private Panel panel14;
        private Label label25;
        private Label lblTotalExpense;
        private PictureBox pictureBox10;
    }
}
