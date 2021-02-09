using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class ChartsPanel : UserControl
    {
        DBTicket dBTicket = new DBTicket();
        public ChartsPanel()
        {
            DateTime time =  DateTime.Today;
            List<int> myList = dBTicket.numberOfTicketLastWeek(time);
            InitializeComponent();

            //cartesianChart1.Title
            this.cartesianChart1.Series = new LiveCharts.SeriesCollection()
            {

                new LineSeries
                {

                    Title = "Series 1",
                    Values = new ChartValues<double>{
                        myList[0],
                        myList[1],
                        myList[2],
                        myList[3],
                        myList[4],
                        myList[5],
                        myList[6],

                    },
                    DataLabels = true,
                    DataContext = true,

        },

                 new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 2, 1, 2, 1 ,3 },
                    DataContext = true

                }

        };
            cartesianChart1.AxisX.Add(
         new Axis
         {
             
             Title = "Ditet e Javes",
             FontSize = 16.0,
             Labels = new[]{ "Dita 1","Dita 2","Dita 3","Dita 4","Dita 5","Dita 6","Dita 7"},
             
             
         });



            /****
             * 
             * 
             * 
             */
            List<System.Windows.Media.SolidColorBrush> colorlist = new List<System.Windows.Media.SolidColorBrush>();
            colorlist.Add(System.Windows.Media.Brushes.Green);
            colorlist.Add(System.Windows.Media.Brushes.Gray);
            colorlist.Add(System.Windows.Media.Brushes.Blue);
            colorlist.Add(System.Windows.Media.Brushes.Tomato);
            colorlist.Add(System.Windows.Media.Brushes.MistyRose);
            colorlist.Add(System.Windows.Media.Brushes.YellowGreen);

            List<List<string>> listofDataForPie = new DBSolvedTicket().numberOfSolvedTicketPerDepartment();
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            SeriesCollection piechartData = new SeriesCollection
                {
       
                };
            for (int i = 0;i<listofDataForPie.Count();i++)
            {
                piechartData.Add(
                    new PieSeries
                    {
                        Title = listofDataForPie[i][0],
                        Values = new ChartValues<double> { Int32.Parse(listofDataForPie[i][1]) },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Fill = colorlist[i]
                    }   
    );
            }
            pieChart1.Series = piechartData;


            pieChart1.LegendLocation = LegendLocation.Bottom;
        }



        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pieChartBtn_Click(object sender, EventArgs e)
        {
            this.panelChart2.Show();
            //this.panel2.Hide();
            this.label1.Text = "Chart 2";
          
            
        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void prevChartBtn_Click(object sender, EventArgs e)
        {
            this.panelChart2.Hide();
            //this.panel2.Hide();
            this.label1.Text = "Chart 1";
        }
    }
}
