
namespace eSupport
{
    partial class Department
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
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addServicePanel = new System.Windows.Forms.Panel();
            this.addServiceBtn = new System.Windows.Forms.Button();
            this.serviceDescField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serviceNameField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.detailsButton = new System.Windows.Forms.Button();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeBtn = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addServicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Maroon;
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(520, 54);
            this.header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.addServicePanel);
            this.panel1.Controls.Add(this.detailsButton);
            this.panel1.Controls.Add(this.deleteSelected);
            this.panel1.Controls.Add(this.addServiceButton);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 308);
            this.panel1.TabIndex = 1;
            // 
            // addServicePanel
            // 
            this.addServicePanel.Controls.Add(this.closeBtn);
            this.addServicePanel.Controls.Add(this.addServiceBtn);
            this.addServicePanel.Controls.Add(this.serviceDescField);
            this.addServicePanel.Controls.Add(this.label6);
            this.addServicePanel.Controls.Add(this.serviceNameField);
            this.addServicePanel.Controls.Add(this.label7);
            this.addServicePanel.Location = new System.Drawing.Point(3, 0);
            this.addServicePanel.Name = "addServicePanel";
            this.addServicePanel.Size = new System.Drawing.Size(517, 305);
            this.addServicePanel.TabIndex = 5;
            this.addServicePanel.Visible = false;
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addServiceBtn.Location = new System.Drawing.Point(219, 239);
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.Size = new System.Drawing.Size(75, 23);
            this.addServiceBtn.TabIndex = 15;
            this.addServiceBtn.Text = "Add";
            this.addServiceBtn.UseVisualStyleBackColor = true;
            this.addServiceBtn.Click += new System.EventHandler(this.addServiceBtn_Click);
            // 
            // serviceDescField
            // 
            this.serviceDescField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceDescField.Location = new System.Drawing.Point(49, 113);
            this.serviceDescField.Multiline = true;
            this.serviceDescField.Name = "serviceDescField";
            this.serviceDescField.Size = new System.Drawing.Size(422, 85);
            this.serviceDescField.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Service description:";
            // 
            // serviceNameField
            // 
            this.serviceNameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceNameField.Location = new System.Drawing.Point(48, 59);
            this.serviceNameField.Name = "serviceNameField";
            this.serviceNameField.Size = new System.Drawing.Size(422, 20);
            this.serviceNameField.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Service name:";
            // 
            // detailsButton
            // 
            this.detailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.detailsButton.Enabled = false;
            this.detailsButton.Location = new System.Drawing.Point(117, 262);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 4;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // deleteSelected
            // 
            this.deleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteSelected.Enabled = false;
            this.deleteSelected.Location = new System.Drawing.Point(22, 262);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(75, 23);
            this.deleteSelected.TabIndex = 3;
            this.deleteSelected.Text = "Delete";
            this.deleteSelected.UseVisualStyleBackColor = true;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // addServiceButton
            // 
            this.addServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addServiceButton.AutoSize = true;
            this.addServiceButton.Location = new System.Drawing.Point(416, 258);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(83, 28);
            this.addServiceButton.TabIndex = 2;
            this.addServiceButton.Text = "Add";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 229);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 275;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.Location = new System.Drawing.Point(300, 239);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Name = "Department";
            this.Size = new System.Drawing.Size(520, 362);
            this.VisibleChanged += new System.EventHandler(this.Department_VisibleChanged);
            this.header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addServicePanel.ResumeLayout(false);
            this.addServicePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Panel addServicePanel;
        private System.Windows.Forms.Button addServiceBtn;
        private System.Windows.Forms.TextBox serviceDescField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serviceNameField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button closeBtn;
    }
}
