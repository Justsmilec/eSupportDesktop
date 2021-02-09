using eSupport.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSupport
{
    class TicketDisplayBox
    {

        public System.Windows.Forms.FlowLayoutPanel flowlayout;
        public System.Windows.Forms.Panel panelToAdd;
        public System.Windows.Forms.Label ServiceRequired;
        public System.Windows.Forms.Label ServiceRequiredText;

        public System.Windows.Forms.Button DelegateButton;
        public System.Windows.Forms.Button ContactButton;
        public System.Windows.Forms.Button Stop_StartButton;
        public System.Windows.Forms.Button FinishButton;
        public Ticket ticket;
        public System.Windows.Forms.Panel delegatePanel;
        public System.Windows.Forms.TextBox delegateTextBox;
        public System.Windows.Forms.Button delegateButton;


        public System.Windows.Forms.OpenFileDialog openFileDialog1;



        public List<string> punonjeslist = new List<string>();
        public string[] punonjes_List;
        DBService dBService = new DBService();
        DBPunonjes dBPunonjes = new DBPunonjes();
        DBSolvedTicket dBSolvedTicket = new DBSolvedTicket();

        public TicketDisplayBox(Ticket ticketModel,System.Windows.Forms.FlowLayoutPanel flowlayout)
        {

            this.flowlayout = flowlayout;
            this.panelToAdd = new System.Windows.Forms.Panel();
            this.ticket = ticketModel;


            this.DelegateButton = DelegateButtonHandler("Delegate");
            this.ContactButton = ContactButtonHandler("Contact");
            this.Stop_StartButton = Stop_StartButtonHandler("Append");
            this.FinishButton = FinishButtonHandler("Finish");

            PanelHandler();
        }
        public System.Windows.Forms.Button DelegateButtonHandler(string testname)
        {
            System.Windows.Forms.Button PressButton = new System.Windows.Forms.Button();
            PressButton.Location = new System.Drawing.Point(3, 230);
            PressButton.Name = "delegateButton";
            PressButton.Size = new System.Drawing.Size(65,23);
            PressButton.TabIndex = 17;
            PressButton.Text = testname;
            PressButton.UseVisualStyleBackColor = true;
            PressButton.Click += new System.EventHandler(this.delegatebutton_Click);
            return PressButton;

        }
        public System.Windows.Forms.Button ContactButtonHandler(string testname)
        {
            System.Windows.Forms.Button PressButton = new System.Windows.Forms.Button();
            PressButton.Location = new System.Drawing.Point(70, 230);
            PressButton.Name = "contactButton";
            PressButton.Size = new System.Drawing.Size(65, 23);
            PressButton.TabIndex = 17;
            PressButton.Text = testname;
            PressButton.UseVisualStyleBackColor = true;
            PressButton.Click += new System.EventHandler(this.contactbutton_Click);
            return PressButton;

        }

        public System.Windows.Forms.Button Stop_StartButtonHandler(string testname)
        {
            System.Windows.Forms.Button PressButton = new System.Windows.Forms.Button();
            PressButton.Location = new System.Drawing.Point(138, 230);
            PressButton.Name = "stop_startButton";
            PressButton.Size = new System.Drawing.Size(65, 23);
            PressButton.TabIndex = 17;
            PressButton.Text = testname;
            PressButton.UseVisualStyleBackColor = true;
            PressButton.Click += new System.EventHandler(this.stop_startbutton_Click);
            return PressButton;

        }
        public System.Windows.Forms.Button FinishButtonHandler(string testname)
        {
            System.Windows.Forms.Button PressButton = new System.Windows.Forms.Button();
            PressButton.Location = new System.Drawing.Point(208, 230);
            PressButton.Name = "finishButton";
            PressButton.Size = new System.Drawing.Size(65, 23);
            PressButton.TabIndex = 17;
            PressButton.Text = testname;
            PressButton.UseVisualStyleBackColor = true;
            PressButton.Click += new System.EventHandler(this.finishbutton_Click);
            return PressButton;

        }
        public void PanelHandler()
        {
            this.panelToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToAdd.BackColor = System.Drawing.Color.LavenderBlush;

            delegatePanel = new System.Windows.Forms.Panel();

            delegatePanel.Location = new System.Drawing.Point(0, 0);
            delegatePanel.BackColor = System.Drawing.Color.Black;

            delegatePanel.Name = "panel33";
            delegatePanel.Size = new System.Drawing.Size(260, 260);
            delegatePanel.TabIndex = 2;
            delegatePanel.BringToFront();
            delegatePanel.Hide();

            //textBOX
            delegateTextBox = new System.Windows.Forms.TextBox();
            delegateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            delegateTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            delegateTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            delegateTextBox.Location = new System.Drawing.Point(48, 183);
            delegateTextBox.Name = "DelegateField";
            delegateTextBox.Size = new System.Drawing.Size(320, 20);
            delegateTextBox.TabIndex = 24;
            delegateTextBox.Leave += new System.EventHandler(this.QualificationField_Leave);

            //Button
            this.delegateButton = new System.Windows.Forms.Button();
            this.delegateButton.Location = new System.Drawing.Point(70, 230);
            this.delegateButton.Name = "contactButton";
            this.delegateButton.Size = new System.Drawing.Size(65, 23);
            this.delegateButton.TabIndex = 17;
            this.delegateButton.Text = "Delegate";
            this.delegateButton.UseVisualStyleBackColor = true;
            this.delegateButton.Click += new System.EventHandler(this.setDelegatebutton_Click);

            this.delegatePanel.Controls.Add(this.delegateTextBox);
            this.delegatePanel.Controls.Add(this.delegateButton);
            this.panelToAdd.Controls.Add(delegatePanel);
            //Service required
            this.panelToAdd.Controls.Add(this.createFirstLabel("Service Required", 12, 18));
            this.panelToAdd.Controls.Add(this.createSecondLabel(this.ticket.Service, 110, 18, 1, 1));

            //Description
            this.panelToAdd.Controls.Add(this.createFirstLabel("Description", 12, 43));
            this.panelToAdd.Controls.Add(this.createSecondLabel(this.ticket.Description, 110, 43, 1, 1));

            //Open Date
            this.panelToAdd.Controls.Add(this.createFirstLabel("Opened Date", 12, 68));
            this.panelToAdd.Controls.Add(this.createSecondLabel(this.ticket.OpenedDate.ToString(), 110, 68, 1, 1));
            DateTime openedDateTime = this.ticket.OpenedDate;
            DateTime finishDate = openedDateTime.AddDays(3);
            //Time to finish
            this.panelToAdd.Controls.Add(this.createFirstLabel("Finish Date", 12, 90));
            this.panelToAdd.Controls.Add(this.createSecondLabel(this.ticket.FinishDate.ToString(), 110, 90, 1, 1));


            //Guarantee
            string guarantee;
            //if(this.ticket.Guarantee == false)
            this.panelToAdd.Controls.Add(this.createFirstLabel("Guarantee", 12, 113));
            this.panelToAdd.Controls.Add(this.createSecondLabel(this.ticket.Guarantee.ToString(), 110, 113, 1, 1));

            //Priority
            this.panelToAdd.Controls.Add(this.createFirstLabel("Priority", 12, 138));
            this.panelToAdd.Controls.Add(this.createSecondLabel(this.ticket.Priority.ToString(), 110, 138, 1, 1));

            //Status
            //this.panelToAdd.Controls.Add(this.createFirstLabel("Status", 12, 155));
            //this.panelToAdd.Controls.Add(this.createSecondLabel(this.ticket.Status, 110, 155, 1, 1));

            //Alarm
            int datedifference = (this.ticket.FinishDate - this.ticket.OpenedDate ).Days;
            string alarm = "---";
            System.Diagnostics.Debug.WriteLine("diff:: "+ datedifference);

            if (datedifference < 2)
            {
                alarm = "Hurry Up";
            }
            this.panelToAdd.Controls.Add(this.createFirstLabel("Alarm", 12, 182));
            this.panelToAdd.Controls.Add(this.createSecondLabel(alarm, 110, 182, 1, 1));


            
            this.panelToAdd.Controls.Add(this.DelegateButton);
            this.panelToAdd.Controls.Add(this.ContactButton);
            this.panelToAdd.Controls.Add(this.Stop_StartButton);
            this.panelToAdd.Controls.Add(this.FinishButton);


            this.panelToAdd.Name = "panel3";
            this.panelToAdd.Size = new System.Drawing.Size(320, 260);
            this.panelToAdd.TabIndex = 1;

        }
        public System.Windows.Forms.Panel returnPanel()
        {
            return panelToAdd;
        }

       
        private void delegatebutton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***::: " + this.DelegateButton.Text);
            /**
             * 
             * Delegate ticket to another worker on the list
             * 
             */
            punonjes_List = dBPunonjes.listOfPunonjesPerDepartment(this.ticket.Department);
            this.delegateTextBox.AutoCompleteCustomSource.AddRange(this.punonjes_List);

            System.Diagnostics.Debug.WriteLine("Ticket on box:: " + this.ticket);
            System.Diagnostics.Debug.WriteLine("Selected Punonjes:: " );
            this.delegatePanel.Show();




        }
        
       private void setDelegatebutton_Click(object sender, EventArgs e)
            {

            if(this.delegateTextBox.Text != "")
            {
                List<Ticket> listOfTicket = new List<Ticket>();
                listOfTicket = dBPunonjes.getAllTicketPerPunonjes(Helper.LoggedinPunonjes, Helper.LoggedinPunonejesEmail);
                listOfTicket.Remove(this.ticket);
                dBPunonjes.removedelegateTicket(Helper.LoggedinPunonjes, Helper.LoggedinPunonejesEmail,ticket);
                dBPunonjes.delegateTicket(this.delegateTextBox.Text, ticket);
                flowlayout.Controls.Remove(this.panelToAdd);
                

                this.delegatePanel.Hide();

            }




        }

        private void contactbutton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***::: " + this.ContactButton.Text);
        }
        private void stop_startbutton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***::: " + this.Stop_StartButton.Text);
            List<Ticket> listOfTicket = new List<Ticket>();
            listOfTicket = dBPunonjes.getAllTicketPerPunonjes(Helper.LoggedinPunonjes, Helper.LoggedinPunonejesEmail);
            dBPunonjes.appendTimeForTicket(3, Helper.LoggedinPunonjes, this.ticket);
            this.flowlayout.Controls.Clear();
            listOfTicket.Clear();
            listOfTicket = new List<Ticket>();
            listOfTicket = dBPunonjes.getAllTicketPerPunonjes(Helper.LoggedinPunonjes, Helper.LoggedinPunonejesEmail);
            List<Ticket> priorityTicket = listOfTicket;
            List<Ticket> finalTicket = new List<Ticket>();
            for (int i = 0; i < listOfTicket.Count(); i++)
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

            for (int i = 0; i < finalTicket.Count(); i++)
            {
                TicketDisplayBox testTicket = new TicketDisplayBox(finalTicket[i], flowlayout);

                this.flowlayout.Controls.Add(testTicket.returnPanel());
            }

            //Send email
            this.sendEmail(this.ticket);
        }
        private void finishbutton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***::: " + this.FinishButton.Text);
            this.createFile("Adem");

            this.OpenFileDialogForm();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = openFileDialog1.FileName;
                System.Diagnostics.Debug.WriteLine("Description :: " + this.ticket.Description);
                //Generate Fatura
                string faturaId = this.ticket.ClientModel.ClientID + ticket.ClientModel.ClientName + ticket.Description;
                int costperService = new DBSubService().getSubService(this.ticket.Service, this.ticket.Department).cost;
                Boolean isGuarantee = new DBDevice().isGuarantee(ticket.ClientModel.ClientID);
                Fatura fatura = new Fatura
                {
                    faturaFilename = faturaId,
                    costTotal = new Fatura().returnTotalCost(costperService, isGuarantee, ticket.Priority),
                    Payed = false
                };
                dBSolvedTicket.Insert(this.ticket, openFileDialog1.SafeFileName,this.ticket.Description,fatura);
                fatura.printFatura(faturaId,isGuarantee,this.ticket);
                //dBPunonjes.deleteTicket(Helper.LoggedinPunonjes, this.ticket);

                this.sendFinishedEmail(this.ticket,faturaId);
            }
        }

        private void QualificationField_Leave(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < this.punonjes_List.Length; i++)
            {
                if (delegateTextBox.Text == this.punonjes_List[i])
                    count++;
            }
            if (count == 0)
                this.delegateTextBox.Text = "";
        }
        public System.Windows.Forms.Label createFirstLabel(string text,int x,int y)
        {
            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(x, y); //12,17
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 13);
            label2.TabIndex = 17;
            label2.Text = text +":";

            return label2;
        }

        public System.Windows.Forms.Label createSecondLabel(string text, int x, int y,int width,int height)
        {
            System.Windows.Forms.Label serviceReqText = new System.Windows.Forms.Label();
            serviceReqText.AutoSize = true;
            serviceReqText.Location = new System.Drawing.Point(x, y);  //110,18
            serviceReqText.Name = text;
            serviceReqText.Size = new System.Drawing.Size(35, 13);
            serviceReqText.TabIndex = 17;
            serviceReqText.Text = text;


            return serviceReqText;
        }

        public void sendEmail(Ticket openedTicket)
        {

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add("ademcani773@gmail.com");
            mail.From = new MailAddress("ademcani773@gmail.com", "eSupport", System.Text.Encoding.UTF8);
            mail.Subject = "Per arsye X kerkesa juaj shtyhet ne pak dite";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = "Pershendetje Z/Znj." + openedTicket.ClientModel.ClientName + " kerkesa juaj per eSupport eshte shtyre\n" +
                "Dorezimi i krye me " + openedTicket.OpenedDate.Date + " dhe kthimi me date " + openedTicket.FinishDate.Date + " \n" +

                " " + openedTicket.Department + "/" + openedTicket.ClientModel.ClientID + ". Faleminderit!!";
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("ademcani773@gmail.com", "12345elb");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
            }

            /*
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            MailAddress from = new MailAddress("ademcani773@gmail.com", "Adem Cani");
            MailAddress to = new MailAddress("ademcani773@gmail.com", "Adem Cani");
            MailMessage message = new MailMessage(from, to);
            message.Body = "This is a test e-mail message sent using gmail as a relay server ";
            message.Subject = "Gmail test email with SSL and Credentials";
            NetworkCredential myCreds = new NetworkCredential("ademcani773@gmail.com", "12345elb", "");
            client.Credentials = myCreds;
            client.UseDefaultCredentials = true;
            client.Send(message);*/
        }

        public void sendFinishedEmail(Ticket openedTicket,string faturaId)
        {

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add("ademcani773@gmail.com");
            mail.From = new MailAddress("ademcani773@gmail.com", "eSupport", System.Text.Encoding.UTF8);
            mail.Subject = openedTicket.ClientModel.ClientID + " e Perfunduar";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = "Pershendetje Z/Znj." + openedTicket.ClientModel.ClientName + " kerkesa juaj per eSupport eshte perfunduar\n" +
                ". Faleminderit!!";
            mail.Attachments.Add(new Attachment("C:/Users/User.WINDOWS-VCRGH5N/Desktop/eSupport/eSupport/Fatura/"+faturaId+".txt"));
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("ademcani773@gmail.com", "12345elb");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
            }

            /*
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            MailAddress from = new MailAddress("ademcani773@gmail.com", "Adem Cani");
            MailAddress to = new MailAddress("ademcani773@gmail.com", "Adem Cani");
            MailMessage message = new MailMessage(from, to);
            message.Body = "This is a test e-mail message sent using gmail as a relay server ";
            message.Subject = "Gmail test email with SSL and Credentials";
            NetworkCredential myCreds = new NetworkCredential("ademcani773@gmail.com", "12345elb", "");
            client.Credentials = myCreds;
            client.UseDefaultCredentials = true;
            client.Send(message);*/
        }


        public void createFile(string fileName1)
        {
            string fileName = @"C:\Users\User.WINDOWS-VCRGH5N\Desktop\eSupport\eSupport\Documentation\test.txt";
            System.Diagnostics.Debug.WriteLine("***** :: File started to create");

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    System.Diagnostics.Debug.WriteLine("***** :: this file exist");

                    //File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                    fs.Write(author, 0, author.Length);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }



        public void OpenFileDialogForm()
        {
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\User.WINDOWS-VCRGH5N\Desktop\eSupport\eSupport\Documentation\";


        }


    }
}
