using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Cereal
{
    public class Cereal
    {

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }


        public Cereal()
        {
            Name = string.Empty;
            Manufacturer = string.Empty;
            Calories = 0;
            Cups = 0;
        }

        public Cereal(string name)
        {
            Name = name;
            Manufacturer = string.Empty;
            Calories = 0;
            Cups = 0;
        }

        public override string ToString()
        {
            return $"{Name} is made by {Manufacturer} and has {Cups.ToString("N")} cups per serving and {Calories.ToString("N2")} calories per serving.";
        }
    }
}
