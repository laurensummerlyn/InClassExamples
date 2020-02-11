using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_JSON_Rick_and_Morty
{
    class RickAndMortyAPIResult
    {
        //only 2 there (in jsonformatter from r&m link) (info and results) so only need two properties
        //info curly brackets on json formatter tells it's object
        //square brackets on results tells array/collection, expand to see curly bracket meaning its list of object

        public InfoObject info { get; set; } //infoobject and result object showed as errors, create class for each
        public List<ResultObject> results { get; set; }
    }

    public class ResultObject
    {
        //result object has 12 properties, don't need to convert all (id name, gender, image, url (random selection))
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public string image { get; set; }
        public override string ToString()
        {
            return $"({id}) {name}";
        }

    }

    public class InfoObject
    {
        //info object has four properties
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }

    }
}
