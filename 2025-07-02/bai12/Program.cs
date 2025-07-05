using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rd = new Random(); // cú pháp tạo ra 1 đối tượng
            // random 1 số ngẫu nhiên
            int soNN = rd.Next(50,101);// 50-100
            Console.WriteLine("số ngẫu nhiên là : "+soNN);

            // muốm lây 1 số từ 0 - sát 1
            double k2 = rd.NextDouble();
            Console.WriteLine("số ngẫu nhiên 2 là : " +k2);
            Console.ReadKey();
        }
    }
}
