using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train102
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator zsumowane = new Calculator();
            Console.WriteLine(zsumowane.Suma(10,8));

            Calculator odjete = new Calculator();
            Console.WriteLine(odjete.Roznica(10, 5));

            Calculator pomnozone = new Calculator();
            Console.WriteLine(pomnozone.Iloczyn(6, 3));

            Calculator podzielone = new Calculator();
            Console.WriteLine(podzielone.Iloraz(10, 2));

            GreekPizza p1 = new GreekPizza();
            p1.Dispaly();
            Console.ReadLine();
        }
    }
}
