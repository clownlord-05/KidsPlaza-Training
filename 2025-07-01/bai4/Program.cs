using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool kq;
            int a = 6;
            int b = 10;
            kq = (a!=b) && (a < 3); 
            Console.WriteLine(" giá trị của kết quả: " +kq);
            Console.ReadKey();
        }
    }
}
