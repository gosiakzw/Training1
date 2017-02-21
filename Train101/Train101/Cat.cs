using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train101
{
    class Cat
    {
        public string name;

        public Cat(string name)// stworzenie konstruktora, ktory pobiera jeden argument name, konstruktor musi miec taka sama nazwe, jak nazwa klasy- w tym przypadku Cat
        {
            this.name = name;
        }

        public void showName()
        {
            Console.WriteLine(name);
        }

    }
}
