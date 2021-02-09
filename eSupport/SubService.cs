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
    public partial class SubService : UserControl
    {
        public static UserControl subServicePanel;
        DBSubService dBSubService = new DBSubService();
        public static string mystring;
        public string selectedSubService;
        public string selecetedSubServiceDepartment;

        public SubService()
        {
            InitializeComponent();
            subServicePanel = this;
        }


        private void deleteSubService_Click(object sender, EventArgs e)
        {
            string toBeSearched = "Department/";
            int ix = this.label1.Text.IndexOf(toBeSearched);
            string code = "";
            if (ix != -1)
            {
                code = this.label1.Text.Substring(ix + toBeSearched.Length);
            }
            dBSubService.Delete(this.selectedSubService,this.selecetedSubServiceDepartment);
            this.subListView.Items.Clear();
            List<SubServiceModel> list = null;
            list = dBSubService.getSubServices(code);
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
                this.subListView.Items.Add(listViewItem);

            }
        }

        private void addSubService_Click(object sender, EventArgs e)
        {
            this.addSubServicePanel.Show();
            this.editingPanel.Hide();

        }

        private void addSubServiceBtn_Click(object sender, EventArgs e)
        {
            string toBeSearched = "Department/";
            int ix = this.label1.Text.IndexOf(toBeSearched);
            string code = "";
            if (ix != -1)
            {
                code = this.label1.Text.Substring(ix + toBeSearched.Length);
            }
            SubServiceModel subService = new SubServiceModel(this.nameField.Text,code, int.Parse(this.costField.Text), int.Parse(this.timeRequiredField.Text));
            
            if(this.nameField.Text != "" && this.costField.Text != "" && this.timeRequiredField.Text != "")
            {
                if(dBSubService.Count(this.nameField.Text) == 0)
                {
                    dBSubService.Insert(subService);
                    this.nameField.Text = "";
                    this.costField.Text = "";
                    this.timeRequiredField.Text = "";

                    //Display directly after inserting and hide add panel
                    this.subListView.Items.Clear();
                    List<SubServiceModel> list = null;
                    list = dBSubService.getSubServices(code);
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
                        this.subListView.Items.Add(listViewItem);

                    }
                    this.addSubServicePanel.Hide();
                }
                else
                {
                    MessageBox.Show("Nje sherbim i tille per "+code+" ekziston");
                }


            }

            else
            {
                MessageBox.Show("Plotesoni fushat e kerkuara");
            }

            
        }
       
        public static void test()
        {
            
        }

        private void subListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.subListView.SelectedItems.Count > 0)
            {
                Console.WriteLine("row : " + subListView.SelectedIndices[0]);

                ListViewItem item = subListView.SelectedItems[0];
                selectedSubService = item.SubItems[1].Text;
                selecetedSubServiceDepartment = item.SubItems[2].Text;
                Console.WriteLine("Selected row : " + selectedSubService);
                this.deleteSubService.Enabled = true;
                this.viewSubService.Enabled = true;
            }
            else
            {
                this.deleteSubService.Enabled = false;
                this.viewSubService.Enabled = false;
            }
        }

        private void viewSubService_Click(object sender, EventArgs e)
        {
            this.addSubServicePanel.Hide();
            this.editingPanel.Show();
            SubServiceModel subservice = dBSubService.getSubService(this.selectedSubService, this.selecetedSubServiceDepartment);
            this.editingnameField.Text = subservice.name;
            this.editingCostField.Text = subservice.cost.ToString();
            this.editingTimeField.Text = subservice.time_required.ToString(); 
            
        }

        private void SubService_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Entered here where i want");
            string toBeSearched = "Department/";
            int ix = this.label1.Text.IndexOf(toBeSearched);
            string code = "";
            if (ix != -1)
            {
                code = this.label1.Text.Substring(ix + toBeSearched.Length);
            }
            this.subListView.Items.Clear();
            List<SubServiceModel> list = null;
            list = dBSubService.getSubServices(Helper.SelectedDepartment);
            Console.WriteLine("Length of subservices:: " +"-- "+Helper.SelectedDepartment+ " - "+ list.Count());
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
                this.subListView.Items.Add(listViewItem);

            }
        }

        private void editcloseBtn_Click(object sender, EventArgs e)
        {
            this.editingPanel.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string toBeSearched = "Department/";
            int ix = this.label1.Text.IndexOf(toBeSearched);
            string code = "";
            if (ix != -1)
            {
                code = this.label1.Text.Substring(ix + toBeSearched.Length);
            }
            SubServiceModel subService = new SubServiceModel(this.editingnameField.Text, code, int.Parse(this.editingCostField.Text), int.Parse(this.editingTimeField.Text));

            if (this.editingnameField.Text != "" && this.editingCostField.Text != "" && this.editingTimeField.Text != "")
            {
                if (dBSubService.Count(this.editingnameField.Text) == 0 || dBSubService.Count(this.editingnameField.Text) == 1)
                {
                    dBSubService.updateSubService(this.selectedSubService,this.selecetedSubServiceDepartment,subService);
                    this.editingnameField.Text = "";
                    this.editingCostField.Text = "";
                    this.editingTimeField.Text = "";

                    //Display directly after inserting and hide add panel
                    this.subListView.Items.Clear();
                    List<SubServiceModel> list = null;
                    list = dBSubService.getSubServices(code);
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
                        this.subListView.Items.Add(listViewItem);

                    }
                    this.editingPanel.Hide();
                }
                else
                {
                    MessageBox.Show("Nje sherbim i tille per " + code + " ekziston");
                }


            }

            else
            {
                MessageBox.Show("Plotesoni fushat e kerkuara");
            }


        }
    }
}
