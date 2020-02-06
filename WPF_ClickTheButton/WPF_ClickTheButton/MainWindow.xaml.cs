using System;
using System.Collections.Generic;
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

namespace WPF_ClickTheButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtName.Text = "";
            txtEmail.Text = "";
        }

        private void btnClick_MouseEnter(object sender, MouseEventArgs e)
        {
            //moves button to this when clicked
            int y = Convert.ToInt32(mainWindow.ActualWidth - btnClick.Width);
            int x = Convert.ToInt32(mainWindow.ActualHeight - btnClick.Height);
            Random rand = new Random();
            btnClick.Margin = new Thickness(rand.Next(y), rand.Next(x),0,0);
        }

        private void grdMain_MouseEnter(object sender, MouseEventArgs e)
        {
            lblInfo.Content = $"X: {e.GetPosition(grdMain).X} Y: {e.GetPosition(grdMain).Y}";
        }
    }
}
