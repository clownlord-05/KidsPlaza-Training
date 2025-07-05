using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baif9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 1;
            int tong = 0;
            do   // while(true) vòng lặp vô hạn
            {
                tong += a;// tong=tong+a
                a++;// a=a+1
            }    
            while (a<=5 );
            Console.WriteLine(" tổng từ 1 đến 5: "+tong);
            Console.ReadLine();
        }
    }
}
