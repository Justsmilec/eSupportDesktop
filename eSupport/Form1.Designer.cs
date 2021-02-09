
namespace eSupport
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.punonjesPanel1 = new eSupport.punonjesPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.punonjesButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.iconimage = new System.Windows.Forms.PictureBox();
            this.adminPanel1 = new eSupport.adminPanel();
            this.loginPunonjes1 = new eSupport.loginPunonjes(this.panel1, this.punonjesPanel1);
            this.loginAdmin1 = new eSupport.loginAdmin(this.panel1, this.adminPanel1);
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginPunonjes1);
            this.panel1.Controls.Add(this.leftPanel);
            this.panel1.Controls.Add(this.loginAdmin1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 399);
            this.panel1.TabIndex = 0;
            // 
            // punonjesPanel1
            // 
            this.punonjesPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.punonjesPanel1.Location = new System.Drawing.Point(0, 0);
            this.punonjesPanel1.Name = "punonjesPanel1";
            this.punonjesPanel1.Size = new System.Drawing.Size(580, 399);
            this.punonjesPanel1.TabIndex = 3;
            // 
            // loginPunonjes1
            // 
            this.loginPunonjes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPunonjes1.Location = new System.Drawing.Point(182, 0);
            this.loginPunonjes1.Name = "loginPunonjes1";
            this.loginPunonjes1.Size = new System.Drawing.Size(398, 399);
            this.loginPunonjes1.TabIndex = 2;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.leftPanel.Controls.Add(this.punonjesButton);
            this.leftPanel.Controls.Add(this.adminButton);
            this.leftPanel.Controls.Add(this.iconimage);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(182, 399);
            this.leftPanel.TabIndex = 0;
            // 
            // punonjesButton
            // 
            this.punonjesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punonjesButton.BackColor = System.Drawing.Color.Transparent;
            this.punonjesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.punonjesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punonjesButton.Location = new System.Drawing.Point(55, 234);
            this.punonjesButton.Name = "punonjesButton";
            this.punonjesButton.Size = new System.Drawing.Size(75, 34);
            this.punonjesButton.TabIndex = 2;
            this.punonjesButton.Text = "Punonjes";
            this.punonjesButton.UseVisualStyleBackColor = false;
            this.punonjesButton.Click += new System.EventHandler(this.punonjesButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminButton.BackColor = System.Drawing.Color.Transparent;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(55, 178);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 38);
            this.adminButton.TabIndex = 1;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // iconimage
            // 
            this.iconimage.Image = global::eSupport.Properties.Resources.human_eye_iris_lens_color_dente_571279ae87c2520fd1c4caad5cbb75b0;
            this.iconimage.Location = new System.Drawing.Point(33, 21);
            this.iconimage.Name = "iconimage";
            this.iconimage.Size = new System.Drawing.Size(120, 108);
            this.iconimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconimage.TabIndex = 0;
            this.iconimage.TabStop = false;
            // 
            // adminPanel1
            // 
            this.adminPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPanel1.Location = new System.Drawing.Point(0, 0);
            this.adminPanel1.Name = "adminPanel1";
            this.adminPanel1.Size = new System.Drawing.Size(580, 399);
            this.adminPanel1.TabIndex = 0;
            // 
            // loginAdmin1
            // 
            this.loginAdmin1.BackColor = System.Drawing.Color.LightCoral;
            this.loginAdmin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginAdmin1.Location = new System.Drawing.Point(0, 0);
            this.loginAdmin1.Name = "loginAdmin1";
            this.loginAdmin1.Size = new System.Drawing.Size(580, 399);
            this.loginAdmin1.TabIndex = 1;
            this.loginAdmin1.Load += new System.EventHandler(this.loginAdmin1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminPanel1);
            this.Controls.Add(this.punonjesPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private loginAdmin loginAdmin1;
        private adminPanel adminPanel1;
        private loginPunonjes loginPunonjes1;
        private System.Windows.Forms.Panel leftPanel;
        private punonjesPanel punonjesPanel1;
        private System.Windows.Forms.Button punonjesButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.PictureBox iconimage;
    }
}

