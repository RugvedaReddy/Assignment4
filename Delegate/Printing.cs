using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Printing
    {
        public void PrintNumber(int number)
        {
            Console.WriteLine(String.Format("in number format is:{0:n0}", number));
        }
        public void PrintMoney(int number)
        {
            Console.WriteLine(String.Format("in money format is:{0:C}", number));
        }
        public void PrintHexaDecimal(int number)
        {
            Console.WriteLine(String.Format("number in hexadecimal format is :{0:X}",number));

        }

    }
}
