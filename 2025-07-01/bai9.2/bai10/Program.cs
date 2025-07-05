using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            int gt = 1;
            Console.WriteLine("nhập n: ");
            n= int.Parse(Console.ReadLine());

            for (int i = 1;i <=n; i++)
            {
                Console.WriteLine("i=" +i);
                gt *= i;//gt = gt *i
            }
            Console.WriteLine("giai thừa {0}={1}", n,gt);


            Console.OutputEncoding = Encoding.UTF8;
            int a, b = 1;
            int gthua = 1;
            Console.WriteLine("nhập a: ");
            a = int.Parse(Console.ReadLine());
            while (b<=a)
            {
                gthua *= b;
                b++;
            }
            Console.WriteLine("kết quả {0} ! = {1}", a,gthua);
            Console.ReadLine();

        }
    }
}
