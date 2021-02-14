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
    public partial class loginAdmin : UserControl
    {
        private Panel paneltoHide;
        private adminPanel paneltoShow;
        public loginAdmin(Panel paneltoHide, adminPanel paneltoShow)
        {
            
            InitializeComponent();
            this.paneltoHide = paneltoHide;
            this.paneltoShow = paneltoShow;
        }


        private void loginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            DBAdmin dBConnect = new DBAdmin();
            int found = dBConnect.Count(this.usernameField.Text, this.emailField.Text, this.passwordField.Text);
            Console.Write("----: " + found);
            if (found == 1)
             {
                    //found
                    this.paneltoHide.Hide();
                    this.paneltoShow.Show();
                    //clear all fields after submit
                    this.usernameField.Text = "";
                    this.emailField.Text = "";
                    this.passwordField.Text = "";
 
            }
            else if (found == 0)
            {
                //Found --> jump to admin page
                MessageBox.Show("Nuk mund te hyni si admin");

            }
            

        }
    }
}
