using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyBackend
{
    public class Episode
    {
        public string name { get; set; }
        public int season { get; set; }
        public int number { get; set; }
        public string coverImage { get; set; }
        public string nicksFavoriteLine { get; set; }            
        public List<string> comments { get; set; }
    }
}
