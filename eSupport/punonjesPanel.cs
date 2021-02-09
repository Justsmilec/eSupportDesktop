using eSupport.Model;
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
    public partial class punonjesPanel : UserControl
    {
        DBPunonjes dBPunonjes = new DBPunonjes();
        public punonjesPanel()
        {

            InitializeComponent();
            

        }

        private void punonjesName_VisibleChanged(object sender, EventArgs e)
        {
            this.punonjesName.Text = Helper.LoggedinPunonjes;
            
        }

        private void openTicketBtn_Click(object sender, EventArgs e)
        {

            this.flowLayoutPanel2.Controls.Clear();
            List<Ticket> listOfTicket = new List<Ticket>();
            listOfTicket = dBPunonjes.getAllTicketPerPunonjes(Helper.LoggedinPunonjes, Helper.LoggedinPunonejesEmail);
            List<Ticket> priorityTicket = listOfTicket;
            List<Ticket> finalTicket = new List<Ticket>();
            for(int i = 0; i < listOfTicket.Count(); i++)
            {
                System.Diagnostics.Debug.WriteLine("***** :: " + listOfTicket[i].Priority.ToString());

                if (listOfTicket[i].Priority.ToString() == "True")
                {
                    finalTicket.Add(listOfTicket[i]);
                }
                
            }
            for (int i = 0; i < listOfTicket.Count(); i++)
            {

                if (listOfTicket[i].Priority.ToString() == "False")
                {
                    finalTicket.Add(listOfTicket[i]);
                }
                
            }

            for(int i = 0;i<finalTicket.Count();i++)
            {
                TicketDisplayBox testTicket = new TicketDisplayBox(finalTicket[i], flowLayoutPanel2);

                this.flowLayoutPanel2.Controls.Add(testTicket.returnPanel());
            }
            this.ticketContainerPanel.Show();
            this.label1.Hide();

            
        }

        private void menu2Button_Click(object sender, EventArgs e)
        {
            //this.label1.Show();
            this.ticketContainerPanel.Hide();
            this.panel1.Hide();
            Helper.Form1.Show();
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void delegateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
