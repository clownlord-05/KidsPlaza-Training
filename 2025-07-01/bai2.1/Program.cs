using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            var y = 113;
            Console.WriteLine("kiểu dữ liệu của y là {0}", y.GetType().ToString());
            var z = "tùng";
            Console.WriteLine("kiểu dữ liệu của z là {0}", z.GetType().ToString());
            var k = 17.9;
            Console.WriteLine("kiểu dữ liệu của k là {0}", k.GetType().ToString());

            const int doSoi = 100;// gán hằng số ( không thể thay đổi hằng số trong suốt quá trình)
            const int doDong = 0;
            const double PI = 3.14;

            Console.WriteLine(" độ đông của nước là {0}", doDong);
            Console.WriteLine(" độ sôi của nước là {0}", doSoi);
            Console.WriteLine("PI= {0}",PI);
            Console.ReadKey();
        }
    }
}
