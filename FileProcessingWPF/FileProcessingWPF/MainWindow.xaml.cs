using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileProcessingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPride_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run r = new Run();

            //adding file to project
            //right click file, properties, security and find object name copy &paste for full name
            //right click project, existing item, all file selection, downloads, find file
            //right click file, properties, copy to output directory copy if newer

            var bookContents = File.ReadAllText("Pride and Prejudice by Jane Austen.txt");
            r.Text = bookContents;
            r.Foreground = Brushes.BlanchedAlmond;
            r.Background = Brushes.Beige;
            r.FontWeight = FontWeights.DemiBold;

            p.Inlines.Add(r);
            fd.Blocks.Add(p);
            rtbPride.Document = fd;

            MessageBox.Show("Made it");
        }

        private void btnSales_Click(object sender, RoutedEventArgs e)
        {
            //read in that csv file
           // string path = @"C:\Users\wats0026\Downloads\SalesJan2009.csv";
            //var contents = File.ReadAllLines(path);

            //might need to use this on exam bc lab computers
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\SalesJan2009.csv";
            var contents = File.ReadAllLines(path);

            double sumOfPrices = 0;
            //int =1 because row 0 is labels
            for(int i =1; i <contents.Length; i++)
            {
                string row = contents[i];

                //split long string up
                var pieces = row.Split(','); //splits them by the comma
                sumOfPrices += Convert.ToDouble(pieces[2]);

                //lst.Sales.Items.Add(row); shows all rows
                lstSales.Items.Add(pieces[1] + " - " + pieces[2]);//shows only product and price
            }

            lstSales.Items.Add($"The total is {sumOfPrices.ToString("C2")}");
            MessageBox.Show("Read successfully");
        }
    }
}
