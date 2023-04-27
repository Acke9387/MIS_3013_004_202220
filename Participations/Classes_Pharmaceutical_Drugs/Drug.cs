using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Pharmaceutical_Drugs
{
    public class Drug
    {

        public string Name { get; set; }
        public string Company { get; set; }
        public string Brand { get; set; }
        public int Code { get; set; }
        public string StreetName { get; set; }


        public Drug()
        {
            Name = string.Empty;
            Company = string.Empty;
            Brand = string.Empty;
            Code = 0;
            StreetName = string.Empty;
        }

        /// <summary>
        /// -----------------------------
        /// |+ |  Drug (comp : string)   |
        /// |  |                         |
        /// </summary>
        /// <param name="comp"></param>
        public Drug(string comp)
        {
            Name = string.Empty;
            Company = comp;
            Brand = string.Empty;
            Code = 0;
            StreetName = string.Empty;
        }

        public override string ToString()
        {
            return $"{StreetName} - {Company} : {Code.ToString("G0")}";
        }
    }
}
