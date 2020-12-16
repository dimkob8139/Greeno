using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greeno.Models
{
    public class Plant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
    }
}
