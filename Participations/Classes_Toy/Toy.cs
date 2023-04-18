using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Toy
{
    public class Toy
    {

        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;


        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        }

        public Toy(string note) : this()
        {
            //Manufacturer = string.Empty;
            //Name = string.Empty;
            //Price = 0;
            //Notes = string.Empty;
            Notes = note;
        }

        public string GetAisle()
        {
            string aisleLetter = Manufacturer.ToUpper()[0].ToString();
            Random r = new Random();

            string aisle = aisleLetter + r.Next(1, 25);

            return aisle;
        }

        public string GetNotes()
        {
            return Notes;
        }

        public void SetNotes(string note)
        {
            Notes = note;
        }

        public override string ToString()
        {
            return $"{Name} made by {Manufacturer} is {Price.ToString("C")} and can be found on aisle {GetAisle()}. \tNotes:{Notes}";
        }

    }
}
