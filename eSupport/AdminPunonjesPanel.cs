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
    public partial class AdminPunonjesPanel : UserControl
    {
        public List<string> department_list = new List<string>();
        public string[] department_List;
        DBService dBService = new DBService();
        DBPunonjes dBPunonjes = new DBPunonjes();
        public AdminPunonjesPanel()
        {
            //Fill autocomplete string for qualification
            for(int i = 0;i<dBService.getAllService().Count();i++)
            {
                department_list.Add(dBService.getAllService()[i].name);
                Console.WriteLine("000:  " + dBService.getAllService()[i].name);
            }

            department_List = new string[dBService.getAllService().Count()];
            for(int i=0;i<department_List.Length;i++)
            {
                department_List[i] = department_list[i];
            }

            InitializeComponent();
            this.QualificationField.AutoCompleteCustomSource.AddRange(department_List);


        }

        private void addPunonjesButton_Click(object sender, EventArgs e)
        {
            this.panel3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel3.Hide();
            PunonjesModel punonjesModel = new PunonjesModel
            {
                name = this.NameField.Text,
                email = this.EmailField.Text,
                phonenumber = this.PhoneField.Text,
                department = this.QualificationField.Text,
                level = this.LevelField.Text,
                password = this.PasswordField.Text,

            };
            dBPunonjes.Insert(punonjesModel);


            this.listView1.Items.Clear();
            List<PunonjesModel> list = null;
            list = dBPunonjes.getAllService();

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
                if (list[i].TicketModel != null){
                    str[6] = list[i].TicketModel.Count().ToString();
                }
                else
                {
                    str[6] = "---";

                }
                ListViewItem listViewItem = new ListViewItem(str);
                this.listView1.Items.Add(listViewItem);


            }
        }

        private void QualificationField_Leave(object sender, EventArgs e)
        {
            int count = 0;
           for(int i = 0;i<this.department_List.Length;i++)
            {
                if (this.QualificationField.Text == this.department_List[i])
                    count++;
            }
            if (count == 0)
                this.QualificationField.Text = "";
        }

        private void AdminPunonjesPanel_VisibleChanged(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            List<PunonjesModel> list = null;
            list = dBPunonjes.getAllService();

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
                    str[6] = list[i].TicketModel.Count().ToString();
                }
                else
                {
                    str[6] = "---";

                }
                ListViewItem listViewItem = new ListViewItem(str);
                this.listView1.Items.Add(listViewItem);
            }
        }
    }
}
