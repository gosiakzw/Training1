using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train102
{
    class Pizza
    {
        private double cena;
        private string nazwa;

        public void Dispaly(string nazwa, double cena)
        {
            var NazwaWyswiatlana = "Pizza" + " " + nazwa + " " + "kosztuje" + " " + cena + " " + "zł";
            Console.WriteLine(NazwaWyswiatlana);

        }

        public Pizza(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            
        }

        public Pizza()
        {
            cena = 0;
            nazwa = "";
        }



    

      
    }
}
