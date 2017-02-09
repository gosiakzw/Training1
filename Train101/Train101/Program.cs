using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train101
{
    class Program
    {
        static void Main(string[] args)
        {
            var girlName = "Ola"; // zad1
            var doubledName = DoubleName(girlName);
            Console.WriteLine(girlName);
            Console.WriteLine(doubledName);
            Console.ReadLine();

            var writeText = WriteText(); //zad2
            Console.WriteLine(writeText);
            Console.ReadLine();

            var name = "Jassie";  //zad3
            Console.WriteLine(WriteText(name));
            Console.ReadLine();

            var ResultofMethod = ShouldReturnDigit();  //zad4
            Console.WriteLine(ResultofMethod);
            Console.ReadLine();

            var number = 5;  // zad5
            var shouldReturnScore = ShouldReturnScore(number);
            Console.WriteLine(shouldReturnScore);
            Console.ReadLine();

            var number1 = 10;
            var number2 = 20;
            var number3 = ShouldReturnProduct(number1, number2);
            Console.WriteLine("A = " + number1);
            Console.WriteLine("B = " + number2);
            Console.WriteLine("Iloczyn A i B = " + number3);
            Console.ReadLine();

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.ReadLine();



           









        }

        static string DoubleName(string name) // zad1
        {
            return name + " " + name;
        }

        static string WriteText() // zad2
        {
            return "Hello";

        }

        static string WriteText(string name)  //zad3
        {
            return "Hello" + " " + name + "!";

        }

        static string ShouldReturnDigit() // zad4
        {
            return "10";
        }

        static int ShouldReturnScore(int x) // zad5
        {
            return 2 * x;
        }

        static int ShouldReturnProduct(int A, int B) // zad6
        {
            return A * B;

        }






    


    }

}


