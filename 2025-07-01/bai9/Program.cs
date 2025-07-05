using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("nhập số nguyên n");
            n= int.Parse(Console.ReadLine()); //ép kiểu
            string traloi = (n % 2 == 0) ? "chẵn" : "lẻ";
            Console.WriteLine("số {0} là {1} ", n,traloi); //{0} biến n
            Console.ReadLine();
        }
    }
}
