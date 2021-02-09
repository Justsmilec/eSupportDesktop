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
    
    public partial class Department : UserControl
    {
        DBService dBService = new DBService();
        DBSubService dBSubService = new DBSubService();
        public string serviceSelected;
        //public static string mystring;

        private SubService subService;

        public Department(SubService subService)
        {
            InitializeComponent();
            this.subService = subService; //reference to another user control (Click details and show user control)
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            this.addServicePanel.Show();
            listView1.Focus();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            Service serviceModel = new Service(this.serviceNameField.Text, this.serviceDescField.Text); 
            dBService.Insert(serviceModel);
            this.listView1.Items.Clear();
            List<Service> list = null;
            list = dBService.getAllService();
            Console.WriteLine("Length " + list.Count());
            for (int i = 0; i < list.Count(); i++)
            {
                //this.panel2.Controls[0].Controls[0].Controls[2] ---- ListView
                string[] str = new string[5];
                str[0] = (i + 1).ToString();
                str[1] = list[i].name;
                str[2] = list[i].description;
                ListViewItem listViewItem = new ListViewItem(str);
                listView1.Items.Add(listViewItem);

            }
            this.addServicePanel.Hide();

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listView1.SelectedItems.Count > 0)
            {
                Console.WriteLine("row : " + listView1.SelectedIndices[0]);

                ListViewItem item = listView1.SelectedItems[0];
                serviceSelected = item.SubItems[1].Text;
                Console.WriteLine("Selected row : " + serviceSelected);
                this.deleteSelected.Enabled = true;
                this.detailsButton.Enabled = true;
                Helper.SelectedDepartment = serviceSelected;
            }
            else
            {
                this.deleteSelected.Enabled = false;
                this.detailsButton.Enabled = false;
            }
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            List<Service> list = null;
            dBService.Delete(this.serviceSelected);
            list = dBService.getAllService();
            Console.WriteLine("Length " + list.Count());
            for (int i = 0; i < list.Count(); i++)
            {
                //this.panel2.Controls[0].Controls[0].Controls[2] ---- ListView
                string[] str = new string[5];
                str[0] = (i + 1).ToString();
                str[1] = list[i].name;
                str[2] = list[i].description;
                ListViewItem listViewItem = new ListViewItem(str);
                listView1.Items.Add(listViewItem);

            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.subService.Show();
            //Console.WriteLine("-----------: " + this.subService.Controls[0].Controls[0].Controls[4]); //Accessing list view
            Label label = new Label();
            label = (Label)this.subService.Controls[0].Controls[1]; // access top label
            label.Text = "Department/"+this.serviceSelected;


            //After display the data to subService ListView
            /*
            ListView lv = (ListView)this.subService.Controls[0].Controls[0].Controls[4];
            lv.Items.Clear();
            List<SubServiceModel> list = null;
            list = dBSubService.getSubServices(this.serviceSelected);
            Console.WriteLine("Length " + list.Count());
            for (int i = 0; i < list.Count(); i++)
            {
                //this.panel2.Controls[0].Controls[0].Controls[2] ---- ListView
                string[] str = new string[5];
                str[0] = (i + 1).ToString();
                str[1] = list[i].name;
                str[2] = list[i].department_name;
                str[3] = list[i].cost.ToString();
                str[4] = list[i].time_required.ToString();
                ListViewItem listViewItem = new ListViewItem(str);
                lv.Items.Add(listViewItem);

            }*/

        }

        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            Service service = new Service(this.serviceNameField.Text, this.serviceDescField.Text);
            if(this.serviceNameField.Text != "" && this.serviceDescField.Text != "")
            {
                if (dBService.Count(this.serviceNameField.Text) == 0)
                {
                    dBService.Insert(service);
                    this.serviceNameField.Text = "";
                    this.serviceDescField.Text = "";

                    this.listView1.Items.Clear();
                    List<Service> list = null;
                    list = dBService.getAllService();
                    Console.WriteLine("Length " + list.Count());
                    for (int i = 0; i < list.Count(); i++)
                    {
                        //this.panel2.Controls[0].Controls[0].Controls[2] ---- ListView
                        string[] str = new string[5];
                        str[0] = (i + 1).ToString();
                        str[1] = list[i].name;
                        str[2] = list[i].description;
                        ListViewItem listViewItem = new ListViewItem(str);
                        listView1.Items.Add(listViewItem);

                    }
                    this.addServicePanel.Hide();
                }
                else
                {
                    //not added -> display message dialog box
                    MessageBox.Show("Ky Sherbim aktualisht ekziston");
                }
            }
            else
            {
                MessageBox.Show("Plotesoni Fushat e kerkuara");

            }


        }

        private void Department_VisibleChanged(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            List<Service> list = null;
            list = dBService.getAllService();
            Console.WriteLine("Length " + list.Count());
            for (int i = 0; i < list.Count(); i++)
            {
                //this.panel2.Controls[0].Controls[0].Controls[2] ---- ListView
                string[] str = new string[5];
                str[0] = (i + 1).ToString();
                str[1] = list[i].name;
                str[2] = list[i].description;
                ListViewItem listViewItem = new ListViewItem(str);
                listView1.Items.Add(listViewItem);

            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.addServicePanel.Hide();
        }
    }
}
