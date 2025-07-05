using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double tong, hieu;
            Console.WriteLine("nhập tổng 2 số: ");
            tong = double.Parse(Console.ReadLine());
            Console.WriteLine(" nhập hiệu 2 số: ");
            hieu = double.Parse(Console.ReadLine());

            double x = (tong +  hieu) / 2;
            double y = (tong - x);
            Console.WriteLine("giá trị x là:" +x);
            Console.WriteLine("giá trị y là:" +y);
            Console.ReadLine();
        }
    }
}
