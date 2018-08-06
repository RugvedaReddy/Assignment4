using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void Print(int num);
        static void Main(string[] args)
        {
            Printing p = new Printing();
            Print p1 = p.PrintNumber;
            p1 += p.PrintHexaDecimal;
            p1 += p.PrintMoney;
            Console.WriteLine("ENTER A NUMBER");
            int n = int.Parse(Console.ReadLine());
            p1(n);

        }
    }
}
