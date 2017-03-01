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
            string[] imiona = new string[5];
            imiona[0] = "Ala";
            imiona[1] = "Gosia";
            imiona[2] = "Ania";
            imiona[3] = "Franek";
            imiona[4] = "John";
            Console.WriteLine(imiona[0]);
            Console.WriteLine(imiona[1]);
            Console.WriteLine(imiona[2]);
            Console.WriteLine(imiona[3]);
            Console.WriteLine(imiona[4]);

            string[] imionka = { "Tomek", "Zosia", "Kalina", "Malwina", "Bartoszek" };
            Console.WriteLine(imionka[0]);
            Console.WriteLine(imionka[1]);
            Console.WriteLine(imionka[2]);
            Console.WriteLine(imionka[3]);
            Console.WriteLine(imionka[4]);

            Calculator calc = new Calculator();
            Console.WriteLine(calc.Suma(10,8));
            Console.WriteLine(calc.Roznica(10, 5));
            Console.WriteLine(calc.Iloczyn(6, 3));
            Console.WriteLine(calc.Iloraz(10, 2));

            GreekPizza p1 = new GreekPizza();
            p1.Dispaly();
            DisplayValues(10, 20);

            var zwroconaSuma = zwrocSume(5, 8);
            Console.WriteLine(zwroconaSuma);

            Pizza.DisplayStatic();

            Pizza greek = new GreekPizza();

            greek.Dispaly();

            Console.ReadLine();

            //1. Stwórz tablice zawierającą pięć imion
            //2.Stwórz inne rodzaje Pizzy(nazwy wymysl) i stwórz listę z różnymi rodzajami Pizzy

           
    

        }

        static void DisplayValues(int a, int b)
        {
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("iloczyn A i B =" + a * b);
        }

       static int zwrocSume(int x, int y)
        {
            var suma = x + y;
            return suma;
        }
    }
}
