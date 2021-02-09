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
    public partial class adminPanel : UserControl
    {
        public adminPanel()
        {
            InitializeComponent();
           
            this.label1.Location = new Point(this.panel2.Left + (this.panel2.Width / 2 - this.label1.Width / 2), this.panel2.Top + (this.panel2.Height / 2 - this.label1.Height / 2));
            this.department1.Hide();

        }

    

        private void adminPanel_Resize(object sender, EventArgs e)
        {
            //icon image change position and size
            //iconimage.Size = new Size(this.leftPanel.Width / 2, this.leftPanel.Height / 5);
            iconimage.Location = new Point(this.adminLeftMenu.Left + (this.adminLeftMenu.Width / 2 - iconimage.Width / 2), this.iconimage.Top);
            this.adminLeftMenu.Width = this.Width / 3;


            this.label1.Location = new Point(this.panel2.Left + this.label1.Width / 2, this.panel2.Top + (this.panel2.Height / 2 - this.label1.Height / 2));
        }

        private void services_department_Click(object sender, EventArgs e)
        {
            this.department1.Show();
            this.adminPunonjesPanel1.Hide();
            this.chartsPanel1.Hide();


            DBService dbService = new DBService();
            /*int i = 0;
            foreach (Control control in this.panel2.Controls[0].Controls[0].Controls)
            {
                i++;
              
                    
                    Console.WriteLine(control.BackColor + "- "+control);
                    //etc.
                
            }*/
            /*
            ListView lv = (ListView)this.panel2.Controls[0].Controls[0].Controls[4];
            lv.Items.Clear();
            List<Service> list = null;
            list = dbService.getAllService();
            Console.WriteLine("Length " + list.Count());
            for (int i = 0;i<list.Count();i++)
            {
                //this.panel2.Controls[0].Controls[0].Controls[2] ---- ListView
                string[] str = new string[5];
                str[0] = (i + 1).ToString();
                str[1] = list[i].name;
                str[2] = list[i].description;
                ListViewItem listViewItem = new ListViewItem(str);
                lv.Items.Add(listViewItem);

            }
            
            */
            //(ListView)this.panel2.Controls[0].Controls[0].Controls[2] = lv;
            Console.WriteLine(this.panel2.Controls.Count);
            Console.WriteLine(this.panel2.Controls[0].Controls.Count);
            //Console.WriteLine(this.panel2.Controls[1].Controls[0]);

            this.label1.Hide();

        }

        private void punonjesPanelBtn_Click(object sender, EventArgs e)
        {
            this.adminPunonjesPanel1.Show();
            this.department1.Hide();
            this.chartsPanel1.Hide();
            this.subService1.Hide();

            DBPunonjes dBPunonjes = new DBPunonjes();
            //foreach (Control control in this.panel2.Controls[0].Controls[0].Controls[0].Controls[5])
            //{



            //Console.WriteLine(control.BackColor + "- " + control);
            //etc.

            //}
            /*
            ListView lv = (ListView)this.panel2.Controls[0].Controls[0].Controls[0].Controls[5];
            lv.Items.Clear();
            List<PunonjesModel> list = null;
            list = dBPunonjes.getAllService();
            Console.WriteLine("Length " + list.Count());
            for (int i = 0; i < list.Count(); i++)
            {
                //this.panel2.Controls[0].Controls[0].Controls[2] ---- ListView
                string[] str = new string[7];
                str[0] = (i + 1).ToString();
                str[1] = list[i].name;
                str[2] = list[i].email;
                str[3] = list[i].phonenumber;
                str[4] = list[i].level;
                str[5] = list[i].department;
                if (list[i].TicketModel != null)
                {
                    str[6] = list[i].TicketModel.Department;
                }
                else
                {
                    str[6] = "---";

                }
                ListViewItem listViewItem = new ListViewItem(str);
                lv.Items.Add(listViewItem);


            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.department1.Hide();
            this.adminPunonjesPanel1.Hide();
            this.chartsPanel1.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
            Helper.Form1.Show();
        }
    }
}
