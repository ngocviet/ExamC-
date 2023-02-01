using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Pizza
    {
        private string toppings;
        private float diameter;
        private int slices;

        public string Toppings { get => toppings; set => toppings = value; }
        public float Diameter { get => diameter; set => diameter = value; }
        public int Slices { get => slices; set => slices = value; }
        public override string ToString()
        {
            return toppings+"\t"+diameter+"  "+slices;
        }
    }
}
