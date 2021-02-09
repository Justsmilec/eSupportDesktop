
namespace eSupport
{
    partial class ChartsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChart2 = new System.Windows.Forms.Panel();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.pieChartBtn = new System.Windows.Forms.Button();
            this.prevChartBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelChart2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Charts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 241);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.panelChart2);
            this.panel2.Controls.Add(this.elementHost1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 241);
            this.panel2.TabIndex = 0;
            // 
            // panelChart2
            // 
            this.panelChart2.Controls.Add(this.elementHost2);
            this.panelChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart2.Location = new System.Drawing.Point(0, 0);
            this.panelChart2.Name = "panelChart2";
            this.panelChart2.Size = new System.Drawing.Size(401, 241);
            this.panelChart2.TabIndex = 1;
            this.panelChart2.Visible = false;
            // 
            // elementHost2
            // 
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(0, 0);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(401, 241);
            this.elementHost2.TabIndex = 0;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.pieChart1;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(401, 241);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // pieChartBtn
            // 
            this.pieChartBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pieChartBtn.Location = new System.Drawing.Point(307, 8);
            this.pieChartBtn.Name = "pieChartBtn";
            this.pieChartBtn.Size = new System.Drawing.Size(75, 23);
            this.pieChartBtn.TabIndex = 2;
            this.pieChartBtn.Text = "NextChart";
            this.pieChartBtn.UseVisualStyleBackColor = true;
            this.pieChartBtn.Click += new System.EventHandler(this.pieChartBtn_Click);
            // 
            // prevChartBtn
            // 
            this.prevChartBtn.Location = new System.Drawing.Point(26, 8);
            this.prevChartBtn.Name = "prevChartBtn";
            this.prevChartBtn.Size = new System.Drawing.Size(75, 23);
            this.prevChartBtn.TabIndex = 3;
            this.prevChartBtn.Text = "PreviousChart";
            this.prevChartBtn.UseVisualStyleBackColor = true;
            this.prevChartBtn.Click += new System.EventHandler(this.prevChartBtn_Click);
            // 
            // ChartsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prevChartBtn);
            this.Controls.Add(this.pieChartBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ChartsPanel";
            this.Size = new System.Drawing.Size(401, 280);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelChart2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChart2;
        private System.Windows.Forms.Button pieChartBtn;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LiveCharts.Wpf.PieChart pieChart1;
        private System.Windows.Forms.Button prevChartBtn;
    }
}
