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
    public partial class loginPunonjes : UserControl
    {
        private Panel paneltoHide;
        private punonjesPanel paneltoShow;
        public loginPunonjes(Panel paneltoHide,punonjesPanel paneltoShow)
        {
            InitializeComponent();
            this.paneltoHide = paneltoHide;
            this.paneltoShow = paneltoShow;
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            Helper.LoggedinPunonjes = this.usernameField.Text;
            Helper.LoggedinPunonejesEmail = this.emailField.Text;
            
            Console.WriteLine("---: " + Helper.LoggedinPunonjes);
            DBPunonjes dBPunonjes = new DBPunonjes();
            if(dBPunonjes.CountifFound(this.usernameField.Text,this.emailField.Text,this.passwordField.Text) == 1)
            {
                this.paneltoHide.Hide();
                this.paneltoShow.Show();
                this.usernameField.Text = "";
                this.emailField.Text = "";
                this.passwordField.Text = "";

            }

            else
            {
                MessageBox.Show("Nuk mund te hyni si punonjes");
            }
            
            
        }
    }
}
