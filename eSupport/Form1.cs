using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSupport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Helper.Form1 = this.panel1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.leftPanel.Width = this.Width / 3;
            iconimage.Location = new Point(this.leftPanel.Left + (this.leftPanel.Width / 2 - iconimage.Width / 2), this.iconimage.Top);
            this.adminPanel1.Hide();
            this.punonjesPanel1.Hide();


        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

            //left panel resize width
            this.leftPanel.Width = this.Width/3;
            //icon image change position and size
            //iconimage.Size = new Size(this.leftPanel.Width / 2, this.leftPanel.Height / 5);
            iconimage.Location = new Point(this.leftPanel.Left + (this.leftPanel.Width / 2 - iconimage.Width / 2),this.iconimage.Top);

            //adminlogin Form resize and position
            this.loginAdmin1.Left = this.leftPanel.Right;
            //this.adminForm.Size = new Size()
        }

        private void loginAdmin1_Load(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.loginAdmin1.Show();
            this.loginPunonjes1.Hide();
       
        }

        private void punonjesButton_Click(object sender, EventArgs e)
        {
            this.loginAdmin1.Hide();
            this.loginPunonjes1.Show();
            //Helper.LoggedinPunonjes = this.
        }

       
    }
}
