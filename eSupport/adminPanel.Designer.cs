
namespace eSupport
{
    partial class adminPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartsPanel1 = new eSupport.ChartsPanel();
            this.adminPunonjesPanel1 = new eSupport.AdminPunonjesPanel();
            this.subService1 = new eSupport.SubService();
            this.label1 = new System.Windows.Forms.Label();
            this.adminLeftMenu = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.staticsticBtn = new System.Windows.Forms.Button();
            this.punonjesPanelBtn = new System.Windows.Forms.Button();
            this.services_department = new System.Windows.Forms.Button();
            this.iconimage = new System.Windows.Forms.PictureBox();
            this.department1 = new eSupport.Department(this.subService1);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.adminLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.adminLeftMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 350);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.chartsPanel1);
            this.panel2.Controls.Add(this.adminPunonjesPanel1);
            this.panel2.Controls.Add(this.subService1);
            this.panel2.Controls.Add(this.department1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(236, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 350);
            this.panel2.TabIndex = 2;
            // 
            // chartsPanel1
            // 
            this.chartsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartsPanel1.Location = new System.Drawing.Point(0, 0);
            this.chartsPanel1.Name = "chartsPanel1";
            this.chartsPanel1.Size = new System.Drawing.Size(284, 350);
            this.chartsPanel1.TabIndex = 4;
            this.chartsPanel1.Visible = false;
            // 
            // adminPunonjesPanel1
            // 
            this.adminPunonjesPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPunonjesPanel1.Location = new System.Drawing.Point(0, 0);
            this.adminPunonjesPanel1.Name = "adminPunonjesPanel1";
            this.adminPunonjesPanel1.Size = new System.Drawing.Size(284, 350);
            this.adminPunonjesPanel1.TabIndex = 3;
            this.adminPunonjesPanel1.Visible = false;
            // 
            // subService1
            // 
            this.subService1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subService1.Location = new System.Drawing.Point(0, 0);
            this.subService1.Name = "subService1";
            this.subService1.Size = new System.Drawing.Size(284, 350);
            this.subService1.TabIndex = 2;
            this.subService1.Visible = false;
            // 
            // department1
            // 
            this.department1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.department1.Location = new System.Drawing.Point(0, 0);
            this.department1.Name = "department1";
            this.department1.Size = new System.Drawing.Size(284, 350);
            this.department1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 350);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME ADMIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminLeftMenu
            // 
            this.adminLeftMenu.AutoSize = true;
            this.adminLeftMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.adminLeftMenu.Controls.Add(this.logoutBtn);
            this.adminLeftMenu.Controls.Add(this.staticsticBtn);
            this.adminLeftMenu.Controls.Add(this.punonjesPanelBtn);
            this.adminLeftMenu.Controls.Add(this.services_department);
            this.adminLeftMenu.Controls.Add(this.iconimage);
            this.adminLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.adminLeftMenu.Name = "adminLeftMenu";
            this.adminLeftMenu.Size = new System.Drawing.Size(236, 350);
            this.adminLeftMenu.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(55, 325);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(129, 34);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // staticsticBtn
            // 
            this.staticsticBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticsticBtn.BackColor = System.Drawing.Color.Transparent;
            this.staticsticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staticsticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticsticBtn.Location = new System.Drawing.Point(55, 285);
            this.staticsticBtn.Name = "staticsticBtn";
            this.staticsticBtn.Size = new System.Drawing.Size(129, 34);
            this.staticsticBtn.TabIndex = 3;
            this.staticsticBtn.Text = "Statisctic";
            this.staticsticBtn.UseVisualStyleBackColor = false;
            this.staticsticBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // punonjesPanelBtn
            // 
            this.punonjesPanelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punonjesPanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.punonjesPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.punonjesPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punonjesPanelBtn.Location = new System.Drawing.Point(55, 234);
            this.punonjesPanelBtn.Name = "punonjesPanelBtn";
            this.punonjesPanelBtn.Size = new System.Drawing.Size(129, 34);
            this.punonjesPanelBtn.TabIndex = 2;
            this.punonjesPanelBtn.Text = "Punonjes";
            this.punonjesPanelBtn.UseVisualStyleBackColor = false;
            this.punonjesPanelBtn.Click += new System.EventHandler(this.punonjesPanelBtn_Click);
            // 
            // services_department
            // 
            this.services_department.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.services_department.BackColor = System.Drawing.Color.Transparent;
            this.services_department.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.services_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.services_department.Location = new System.Drawing.Point(55, 178);
            this.services_department.Name = "services_department";
            this.services_department.Size = new System.Drawing.Size(129, 38);
            this.services_department.TabIndex = 1;
            this.services_department.Text = "Department";
            this.services_department.UseVisualStyleBackColor = false;
            this.services_department.Click += new System.EventHandler(this.services_department_Click);
            // 
            // iconimage
            // 
            this.iconimage.Image = global::eSupport.Properties.Resources.human_eye_iris_lens_color_dente_571279ae87c2520fd1c4caad5cbb75b0;
            this.iconimage.Location = new System.Drawing.Point(55, 20);
            this.iconimage.Name = "iconimage";
            this.iconimage.Size = new System.Drawing.Size(120, 108);
            this.iconimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconimage.TabIndex = 0;
            this.iconimage.TabStop = false;
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "adminPanel";
            this.Size = new System.Drawing.Size(520, 350);
            this.Resize += new System.EventHandler(this.adminPanel_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.adminLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel adminLeftMenu;
        private System.Windows.Forms.Button punonjesPanelBtn;
        private System.Windows.Forms.Button services_department;
        private System.Windows.Forms.PictureBox iconimage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private SubService subService1;
        private AdminPunonjesPanel adminPunonjesPanel1;
        private System.Windows.Forms.Button staticsticBtn;
        private ChartsPanel chartsPanel1;
        private System.Windows.Forms.Button logoutBtn;
        private Department department1;
    }
}
