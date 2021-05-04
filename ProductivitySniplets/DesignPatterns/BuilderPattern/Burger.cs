using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Burger
    {
        public int NumPatties { get; set; }
        public bool Cheese { get; set; }
        public bool Bacon { get; set; }
        public bool Pickles { get; set; }
        public bool Letuce { get; set; }
        public bool Tomato { get; set; }
    }
}