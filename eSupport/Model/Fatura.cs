using eSupport.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSupport
{
    class Fatura
    {
        public string faturaFilename { get; set; }
        public double costTotal { get; set; }
        public Boolean Payed { get; set; }

        public double returnTotalCost(int cost,Boolean guarantee,Boolean priority)
        {
            double totalcost = cost;

            if (priority)
            {
                if (!guarantee)
                    totalcost += totalcost / 3; // if priority increase cost by 1/3
                else
                    totalcost += totalcost / 6;
            }

            else
            {
                if (!guarantee)
                    totalcost += totalcost / 8;
            }

            return totalcost;
        }

        public void printFatura(string faturaId,Boolean guarant,Ticket ticket)
        {
            string fileName = @"C:\Users\User.WINDOWS-VCRGH5N\Desktop\eSupport\eSupport\Fatura\"+faturaId+".txt";

            try
            {
                if (File.Exists(fileName))
                {
                    System.Diagnostics.Debug.WriteLine("***** :: this file exist");
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("Client Name: " + ticket.ClientModel.ClientName+ Environment.NewLine);
                    fs.Write(title, 0, title.Length);
                    byte[] deviceId = new UTF8Encoding(true).GetBytes("Device ID: "+ ticket.ClientModel.ClientID + Environment.NewLine);
                    fs.Write(deviceId, 0, deviceId.Length);
                    byte[] guarantee = new UTF8Encoding(true).GetBytes("Guarantee: " + guarant + Environment.NewLine);
                    fs.Write(guarantee, 0, guarantee.Length);
                    byte[] priority = new UTF8Encoding(true).GetBytes("Priority: " + ticket.Priority + Environment.NewLine);
                    fs.Write(priority, 0, priority.Length);
                    byte[] cost = new UTF8Encoding(true).GetBytes("Cost: " + this.costTotal + Environment.NewLine);
                    fs.Write(cost, 0, cost.Length);
                    byte[] faturaID = new UTF8Encoding(true).GetBytes("Fatura ID: " + faturaId);
                    fs.Write(faturaID, 0, faturaID.Length);
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
    }
}
