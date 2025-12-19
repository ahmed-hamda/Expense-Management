namespace ExpenseManagementSystemsVBDotNet
{
    partial class UCKpisForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKpis;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            chartKpis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartKpis).BeginInit();
            SuspendLayout();
            // 
            // chartKpis
            // 
            chartKpis.BackColor = SystemColors.GradientInactiveCaption;
            chartKpis.Dock = DockStyle.Fill;
            chartKpis.Location = new Point(0, 0);
            chartKpis.Margin = new Padding(3, 4, 3, 4);
            chartKpis.Name = "chartKpis";
            chartKpis.Size = new Size(1216, 847);
            chartKpis.TabIndex = 0;
            chartKpis.Text = "chartKpis";
            chartKpis.Click += chartKpis_Click;
            // 
            // UCKpisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chartKpis);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCKpisForm";
            Size = new Size(1216, 847);
            ((System.ComponentModel.ISupportInitialize)chartKpis).EndInit();
            ResumeLayout(false);
        }
    }
}
