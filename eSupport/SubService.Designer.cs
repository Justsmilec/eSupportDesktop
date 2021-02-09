
namespace eSupport
{
    partial class SubService
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
            this.SpecificDepartment = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addSubServicePanel = new System.Windows.Forms.Panel();
            this.timeRequiredField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addSubServiceBtn = new System.Windows.Forms.Button();
            this.costField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteSubService = new System.Windows.Forms.Button();
            this.addSubService = new System.Windows.Forms.Button();
            this.subListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewSubService = new System.Windows.Forms.Button();
            this.editingPanel = new System.Windows.Forms.Panel();
            this.editingTimeField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.editingCostField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editingnameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editcloseBtn = new System.Windows.Forms.Button();
            this.SpecificDepartment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addSubServicePanel.SuspendLayout();
            this.editingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpecificDepartment
            // 
            this.SpecificDepartment.BackColor = System.Drawing.Color.Orange;
            this.SpecificDepartment.Controls.Add(this.panel1);
            this.SpecificDepartment.Controls.Add(this.label1);
            this.SpecificDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecificDepartment.Location = new System.Drawing.Point(0, 0);
            this.SpecificDepartment.Name = "SpecificDepartment";
            this.SpecificDepartment.Size = new System.Drawing.Size(472, 346);
            this.SpecificDepartment.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.editingPanel);
            this.panel1.Controls.Add(this.viewSubService);
            this.panel1.Controls.Add(this.addSubServicePanel);
            this.panel1.Controls.Add(this.deleteSubService);
            this.panel1.Controls.Add(this.addSubService);
            this.panel1.Controls.Add(this.subListView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 314);
            this.panel1.TabIndex = 11;
            // 
            // addSubServicePanel
            // 
            this.addSubServicePanel.Controls.Add(this.timeRequiredField);
            this.addSubServicePanel.Controls.Add(this.label8);
            this.addSubServicePanel.Controls.Add(this.addSubServiceBtn);
            this.addSubServicePanel.Controls.Add(this.costField);
            this.addSubServicePanel.Controls.Add(this.label6);
            this.addSubServicePanel.Controls.Add(this.nameField);
            this.addSubServicePanel.Controls.Add(this.label7);
            this.addSubServicePanel.Location = new System.Drawing.Point(304, 35);
            this.addSubServicePanel.Name = "addSubServicePanel";
            this.addSubServicePanel.Size = new System.Drawing.Size(472, 314);
            this.addSubServicePanel.TabIndex = 10;
            this.addSubServicePanel.Visible = false;
            // 
            // timeRequiredField
            // 
            this.timeRequiredField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeRequiredField.Location = new System.Drawing.Point(128, 172);
            this.timeRequiredField.Name = "timeRequiredField";
            this.timeRequiredField.Size = new System.Drawing.Size(223, 20);
            this.timeRequiredField.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Service time required:";
            // 
            // addSubServiceBtn
            // 
            this.addSubServiceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addSubServiceBtn.Location = new System.Drawing.Point(197, 234);
            this.addSubServiceBtn.Name = "addSubServiceBtn";
            this.addSubServiceBtn.Size = new System.Drawing.Size(75, 23);
            this.addSubServiceBtn.TabIndex = 10;
            this.addSubServiceBtn.Text = "Add";
            this.addSubServiceBtn.UseVisualStyleBackColor = true;
            this.addSubServiceBtn.Click += new System.EventHandler(this.addSubServiceBtn_Click);
            // 
            // costField
            // 
            this.costField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costField.Location = new System.Drawing.Point(128, 114);
            this.costField.Name = "costField";
            this.costField.Size = new System.Drawing.Size(223, 20);
            this.costField.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Service cost:";
            // 
            // nameField
            // 
            this.nameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameField.Location = new System.Drawing.Point(128, 52);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(223, 20);
            this.nameField.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Service name:";
            // 
            // deleteSubService
            // 
            this.deleteSubService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteSubService.Enabled = false;
            this.deleteSubService.Location = new System.Drawing.Point(12, 285);
            this.deleteSubService.Name = "deleteSubService";
            this.deleteSubService.Size = new System.Drawing.Size(75, 23);
            this.deleteSubService.TabIndex = 11;
            this.deleteSubService.Text = "Delete";
            this.deleteSubService.UseVisualStyleBackColor = true;
            this.deleteSubService.Click += new System.EventHandler(this.deleteSubService_Click);
            // 
            // addSubService
            // 
            this.addSubService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSubService.AutoSize = true;
            this.addSubService.Location = new System.Drawing.Point(374, 280);
            this.addSubService.Name = "addSubService";
            this.addSubService.Size = new System.Drawing.Size(83, 31);
            this.addSubService.TabIndex = 10;
            this.addSubService.Text = "Add";
            this.addSubService.UseVisualStyleBackColor = true;
            this.addSubService.Click += new System.EventHandler(this.addSubService_Click);
            // 
            // subListView
            // 
            this.subListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2});
            this.subListView.FullRowSelect = true;
            this.subListView.HideSelection = false;
            this.subListView.Location = new System.Drawing.Point(12, 15);
            this.subListView.Name = "subListView";
            this.subListView.Size = new System.Drawing.Size(445, 264);
            this.subListView.TabIndex = 9;
            this.subListView.UseCompatibleStateImageBehavior = false;
            this.subListView.View = System.Windows.Forms.View.Details;
            this.subListView.SelectedIndexChanged += new System.EventHandler(this.subListView_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Department";
            this.columnHeader6.Width = 275;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cost";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time Required";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(96, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(513, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Add Sub Service";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Department/Laptop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewSubService
            // 
            this.viewSubService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.viewSubService.Enabled = false;
            this.viewSubService.Location = new System.Drawing.Point(99, 284);
            this.viewSubService.Name = "viewSubService";
            this.viewSubService.Size = new System.Drawing.Size(75, 23);
            this.viewSubService.TabIndex = 13;
            this.viewSubService.Text = "Details";
            this.viewSubService.UseVisualStyleBackColor = true;
            this.viewSubService.Click += new System.EventHandler(this.viewSubService_Click);
            // 
            // editingPanel
            // 
            this.editingPanel.Controls.Add(this.editcloseBtn);
            this.editingPanel.Controls.Add(this.editingTimeField);
            this.editingPanel.Controls.Add(this.label2);
            this.editingPanel.Controls.Add(this.editBtn);
            this.editingPanel.Controls.Add(this.editingCostField);
            this.editingPanel.Controls.Add(this.label3);
            this.editingPanel.Controls.Add(this.editingnameField);
            this.editingPanel.Controls.Add(this.label4);
            this.editingPanel.Location = new System.Drawing.Point(99, 32);
            this.editingPanel.Name = "editingPanel";
            this.editingPanel.Size = new System.Drawing.Size(472, 314);
            this.editingPanel.TabIndex = 14;
            this.editingPanel.Visible = false;
            // 
            // editingTimeField
            // 
            this.editingTimeField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editingTimeField.Location = new System.Drawing.Point(128, 172);
            this.editingTimeField.Name = "editingTimeField";
            this.editingTimeField.Size = new System.Drawing.Size(223, 20);
            this.editingTimeField.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Service time required:";
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBtn.Location = new System.Drawing.Point(180, 234);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // editingCostField
            // 
            this.editingCostField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editingCostField.Location = new System.Drawing.Point(128, 114);
            this.editingCostField.Name = "editingCostField";
            this.editingCostField.Size = new System.Drawing.Size(223, 20);
            this.editingCostField.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Service cost:";
            // 
            // editingnameField
            // 
            this.editingnameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editingnameField.Location = new System.Drawing.Point(128, 52);
            this.editingnameField.Name = "editingnameField";
            this.editingnameField.Size = new System.Drawing.Size(223, 20);
            this.editingnameField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Service name:";
            // 
            // editcloseBtn
            // 
            this.editcloseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editcloseBtn.Location = new System.Drawing.Point(261, 234);
            this.editcloseBtn.Name = "editcloseBtn";
            this.editcloseBtn.Size = new System.Drawing.Size(75, 23);
            this.editcloseBtn.TabIndex = 13;
            this.editcloseBtn.Text = "Close";
            this.editcloseBtn.UseVisualStyleBackColor = true;
            this.editcloseBtn.Click += new System.EventHandler(this.editcloseBtn_Click);
            // 
            // SubService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpecificDepartment);
            this.Name = "SubService";
            this.Size = new System.Drawing.Size(472, 346);
            this.VisibleChanged += new System.EventHandler(this.SubService_VisibleChanged);
            this.SpecificDepartment.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addSubServicePanel.ResumeLayout(false);
            this.addSubServicePanel.PerformLayout();
            this.editingPanel.ResumeLayout(false);
            this.editingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SpecificDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addSubServicePanel;
        private System.Windows.Forms.Button addSubServiceBtn;
        private System.Windows.Forms.TextBox costField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteSubService;
        private System.Windows.Forms.Button addSubService;
        private System.Windows.Forms.ListView subListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox timeRequiredField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button viewSubService;
        private System.Windows.Forms.Panel editingPanel;
        private System.Windows.Forms.TextBox editingTimeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox editingCostField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editingnameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editcloseBtn;
    }
}
