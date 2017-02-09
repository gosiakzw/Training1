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
            //tu powinnas inaczej nazwac zmienna - np hello
            Console.WriteLine(writeText);
            Console.ReadLine();

            var name = "Jassie";  //zad3 
            /*wg zadania mialas najpierw przypisac rezultat do jakiejs zmiennej
             * a potem dopiero wysiwetlic ta zmienna
             * ale ogolnie OK */
            Console.WriteLine(WriteText(name));
            Console.ReadLine();

            var ResultofMethod = ShouldReturnDigit();  //zad4
            /*tu powinnas inaczej nazwac zmienna - np number
            * poza tym staraj sie przyzwyczaic do konwencji ze zmienne zaczynamy z malej litery
            * ale o sposobie nazywania i tak jeszcze bedziemy rozmawiac ;) */
            Console.WriteLine(ResultofMethod);
            Console.ReadLine();

            var number = 5;  // zad5
            var shouldReturnScore = ShouldReturnScore(number);
            /*tu nazwa zmiennej wynika z kontekstu i wlasciwie biorac pod uwage
             * ze nie znasz kontekstu to moglabys nazwac rezultat metody jako doubleNumber 
             * ale rownie dobrze mogloby to byc calculatedNumber lub result */
            Console.WriteLine(shouldReturnScore);
            Console.ReadLine();

            var number1 = 10;
            var number2 = 20;
            var number3 = ShouldReturnProduct(number1, number2);
            // to wypisanie na ekranie zmiennych i wyniku powinno być w metodzie
            Console.WriteLine("A = " + number1); 
            Console.WriteLine("B = " + number2);
            Console.WriteLine("Iloczyn A i B = " + number3);
            Console.ReadLine();

            /*tu brakuje osobnej metody i troche niejasna nazwa zmiennej
            * a tak wyglada polecenie ktore zwraca nam tylko godzine:
            * var currentTime = DateTime.Now.ToShortTimeString();
            * ale to polecenie powinno byc uzyte w metodzie */
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.ReadLine();

            // mam jeszcze jedna uwage - usuwaj dodatkowe puste linie
            // puste linie powinny byc co najwyzej pojedyncze miedzy logicznymi blokami
        }

        static string DoubleName(string name) // zad1 - OK
        {
            return name + " " + name;
        }

        static string WriteText() // zad2 - OK ale nazwa powinna byc bardziej odpowiednie np SayHello()
        {
            return "Hello";

        }

        static string WriteText(string name)  //zad3 - OK ale nazwa powinna byc bardziej odpowiednie np SayHello()
        {
            return "Hello" + " " + name + "!";

        }

        static string ShouldReturnDigit() // zad4 - OK ale nazwa powinna byc bardziej odpowiednie np Ten()
        {
            return "10";
        }

        static int ShouldReturnScore(int x) // zad5 - OK ale nazwa powinna byc bardziej odpowiednie np DoubleNumber()
        {
            return 2 * x;
        }

        static int ShouldReturnProduct(int A, int B) // zad6 - OK ale nazwa powinna byc bardziej odpowiednie np Multiply()
        {
            return A * B;
            /* ta metoda miala robic troche wiecej:
             * 6. Stwórz metodę która jako parametry ma dwie liczby całkowite A i B,
             * wypisuje na ekranie ich wartości w taki sposób: A= …tu wartość A…,
             * w drugiej linii B= …tu wartość B…,
             * w trzeciej linii: iloczyn A i B = … tu iloczyn A i B,
             * metoda jednocześnie zwraca iloczyn A i B 
             * 
             * a Twoja metoda jedyne co robi to zwraca iloczyn           
             */
        }
    }
}


