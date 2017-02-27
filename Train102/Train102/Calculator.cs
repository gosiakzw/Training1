using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train102
{
    class Calculator
    {
       

        public int Suma(int x, int y)
        {
            var suma = x + y;
            return suma;
        }

 

      

        public int Roznica(int x, int y)
        {
            var roznica = x - y;
            return roznica;
        }

        public int Iloczyn(int x, int y)
        {
            var iloczyn = x * y;
            return iloczyn;
        }

        public int Iloraz(int x, int y)
        {
            var iloraz = x / y;
            return iloraz;
        }
    }
}
