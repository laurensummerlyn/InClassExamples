using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WPF_JSON_Rick_and_Morty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// downloaded newton by right click on project, manage nuget package
    /// Rick and MOrty json link; documentation to characters link and json formatting to get properties for classes
    /// want list box to show characters 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string apiURL = "https://rickandmortyapi.com/api/character/"; //link of all crazy unformatted json
            RickAndMortyAPIResult apiInfo;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(apiURL).Result;
                //go to web server and wait until result comes back then give me result
                //json variable will have all contents of the link


                //need to convert json back to class
                apiInfo = JsonConvert.DeserializeObject<RickAndMortyAPIResult>(json);

            }

            //results holds all character info; list object, need loop to iterate through
            foreach (var character in apiInfo.results)
            {
                lstCharacters.Items.Add(character);
            }
        }

        private void lstCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //harry potter choice on list box, select character to show image
            ResultObject selectedCharacter = (ResultObject)lstCharacters.SelectedItem;
            //give url to image; bitmap image downloads image bits
            imgCharacter.Source = new BitmapImage(new System.Uri(selectedCharacter.image));
        }
    }
}
