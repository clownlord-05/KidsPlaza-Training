using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float x, y;
            x = 5;
            y = 4;
            Console.WriteLine("x=" +x);

            x += y; //x= x+y
            Console.WriteLine("x= " +x);

            int n;
            Console.WriteLine("nhập n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("vừa nhập {0}", n);
            if (n % 2 == 0)
                Console.WriteLine("số {0} là sô chẵn", n);
            else
                Console.WriteLine("số {0} là số lẻ", n);

            Console.ReadLine();

        }
    }
}
