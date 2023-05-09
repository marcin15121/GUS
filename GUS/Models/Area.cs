using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUS.Models
{
    public class Area
    {
        public int id { get; set; }

        public string nazwa { get; set; }

        [JsonProperty("id-nadrzedny-element")]
        public int id_nadrzedny_element { get; set; }

        [JsonProperty("id-poziom")]
        public int id_poziom { get; set; }

        [JsonProperty("nazwa-poziom")]
        public string nazwa_poziom { get; set; }

        [JsonProperty("czy-zmienne")]
        public bool czy_zmienne { get; set; }
    }
}
