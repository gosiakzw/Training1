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
            var girlName = "Ola";
            var doubledName = DoubleName(girlName);
            Console.WriteLine(girlName);
            Console.WriteLine(doubledName);
            Console.ReadLine();
        }

        static string DoubleName(string name)
        {
            return name + " " + name;
        }


    }
}


