
namespace eSupport
{
    partial class punonjesPanel
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
            this.ticketContainerPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.adminLeftMenu = new System.Windows.Forms.Panel();
            this.punonjesName = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.openTicketBtn = new System.Windows.Forms.Button();
            this.iconimage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.ticketContainerPanel.SuspendLayout();
            this.adminLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.ticketContainerPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.adminLeftMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 355);
            this.panel1.TabIndex = 0;
            // 
            // ticketContainerPanel
            // 
            this.ticketContainerPanel.BackColor = System.Drawing.Color.HotPink;
            this.ticketContainerPanel.Controls.Add(this.flowLayoutPanel2);
            this.ticketContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketContainerPanel.Location = new System.Drawing.Point(206, 0);
            this.ticketContainerPanel.Name = "ticketContainerPanel";
            this.ticketContainerPanel.Size = new System.Drawing.Size(247, 355);
            this.ticketContainerPanel.TabIndex = 4;
            this.ticketContainerPanel.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(247, 355);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(206, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 355);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME PUNONJES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminLeftMenu
            // 
            this.adminLeftMenu.AutoSize = true;
            this.adminLeftMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.adminLeftMenu.Controls.Add(this.punonjesName);
            this.adminLeftMenu.Controls.Add(this.logOutBtn);
            this.adminLeftMenu.Controls.Add(this.openTicketBtn);
            this.adminLeftMenu.Controls.Add(this.iconimage);
            this.adminLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.adminLeftMenu.Name = "adminLeftMenu";
            this.adminLeftMenu.Size = new System.Drawing.Size(206, 355);
            this.adminLeftMenu.TabIndex = 2;
            // 
            // punonjesName
            // 
            this.punonjesName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punonjesName.AutoSize = true;
            this.punonjesName.Location = new System.Drawing.Point(68, 132);
            this.punonjesName.Name = "punonjesName";
            this.punonjesName.Size = new System.Drawing.Size(0, 13);
            this.punonjesName.TabIndex = 3;
            this.punonjesName.VisibleChanged += new System.EventHandler(this.punonjesName_VisibleChanged);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(55, 234);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(99, 34);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.menu2Button_Click);
            // 
            // openTicketBtn
            // 
            this.openTicketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openTicketBtn.BackColor = System.Drawing.Color.Transparent;
            this.openTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTicketBtn.Location = new System.Drawing.Point(55, 178);
            this.openTicketBtn.Name = "openTicketBtn";
            this.openTicketBtn.Size = new System.Drawing.Size(99, 38);
            this.openTicketBtn.TabIndex = 1;
            this.openTicketBtn.Text = "Ticket";
            this.openTicketBtn.UseVisualStyleBackColor = false;
            this.openTicketBtn.Click += new System.EventHandler(this.openTicketBtn_Click);
            // 
            // iconimage
            // 
            this.iconimage.Image = global::eSupport.Properties.Resources.human_eye_iris_lens_color_dente_571279ae87c2520fd1c4caad5cbb75b0;
            this.iconimage.Location = new System.Drawing.Point(44, 21);
            this.iconimage.Name = "iconimage";
            this.iconimage.Size = new System.Drawing.Size(120, 108);
            this.iconimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconimage.TabIndex = 0;
            this.iconimage.TabStop = false;
            // 
            // punonjesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "punonjesPanel";
            this.Size = new System.Drawing.Size(453, 355);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ticketContainerPanel.ResumeLayout(false);
            this.adminLeftMenu.ResumeLayout(false);
            this.adminLeftMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel adminLeftMenu;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button openTicketBtn;
        private System.Windows.Forms.PictureBox iconimage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label punonjesName;
        private System.Windows.Forms.Panel ticketContainerPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
