using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_09_footgolf
{
    internal class Versenyző
    {
        public string Név { get; set; }
        public string Nem { get; set; }
        public string EgyesületNév { get; set; }
        public int PontSzám { get; set; }


        public Versenyző(string sor)
        {
            string[] s = sor.Split(';');

            Név = s[0];
            Nem = s[1];
            EgyesületNév = s[2];
            PontSzám = int.Parse(s[3]);

            
        }
    }
}
