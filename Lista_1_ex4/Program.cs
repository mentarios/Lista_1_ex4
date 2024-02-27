using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex4
{
    internal class Program
    {
        //oi
        static void Main(string[] args)
        {
            int a, b, x;
            Console.WriteLine("digite o primeiro numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero");
            x = int.Parse(Console.ReadLine());
            int res;
            if (x <= 5)
            {
                res = (b - a) * x;
            }
            else { int form = (a + b) * x; }
        }
    }
}
