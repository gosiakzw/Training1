using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train101
{
    class Cat
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public void pokaz_info()
        {
            Console.WriteLine(name);
        }

    }
}
