using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Train101
{
    
   
 class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2017, 2, 21, 12, 27, 0).AddHours(10);
            var Tekst = "anything";
            var Number = 14;
           
            Produkty p1 = new Produkty(150.66);
            Cat Little = new Cat("Little Cat");
            Little.showName();
            BlackCat c1 = new BlackCat("Black");
            c1.showName();
            
            Console.WriteLine(TekstWithValue(Tekst, Number.ToString()));
            Console.WriteLine(NowDate());
            Console.WriteLine(NewDate(dateTime.ToString()));
            Console.WriteLine(NowDate());
            Console.ReadLine();
           


        }

        static string NowDate()
        {
            return DateTime.Now.ToLongDateString();
        }

        static string NewDate(string dateTime)
        {
            return dateTime;  // tutaj za cholerę nie wiem, jak to zrobić z dwomoma parametrami


        }

        static string TekstWithValue(string Tekst, string Number)
        {
            return Tekst + "*" + Number;
        }

        
        

    }

    class Produkty
    {
        private double cena;

        public Produkty(double cena)
        {
            this.cena = cena;
        }

        public void pokazCene()
        {
            Console.WriteLine(cena);
        }
    }
}





