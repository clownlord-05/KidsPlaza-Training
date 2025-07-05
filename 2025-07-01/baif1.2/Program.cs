using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baif1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;
            for (int i =0; i<=10; i+=2)// bước nhảy
            {
                Console.WriteLine("i=" +i);
                tong = tong + i;
                Console.WriteLine("tong"+tong);
            }
            Console.ReadLine();
        }
    }
}
