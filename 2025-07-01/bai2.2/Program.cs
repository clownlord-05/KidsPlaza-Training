using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float x, y;
            Console.WriteLine("nhập giá trị x: ");
            x = float.Parse(Console.ReadLine()); // đọc tât cả dư liệu
            Console.WriteLine(" nhập giá trị y: ");
            y = float.Parse(Console.ReadLine());

            float z1 = x + y;
            float z2 = x - y;
            float z3 = x * y;
            float z4 = x / y;
            float z5 = x % y;
            Console.WriteLine("{0} + {1} = {2}", x, y, z1);
            Console.WriteLine("{0} - {1} = {2}", x, y, z2);
            Console.WriteLine("{0} * {1} = {2}", x, y, z3);
            Console.WriteLine("{0} / {1} = {2}", x, y, z4);
            Console.WriteLine("{0} %  {1} = {2}", x, y, z5);
            Console.ReadKey();
        }
    }
}
