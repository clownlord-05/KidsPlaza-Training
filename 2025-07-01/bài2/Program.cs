using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            string hoTen;
            float diemToan;
            float diemVan;
            Console.WriteLine("nhập họ tên");
            hoTen = Console.ReadLine();

            Console.WriteLine("nhập điểm toán");
            diemToan = float.Parse( Console.ReadLine());

            Console.WriteLine("nhập điêm văn");
            diemVan = float.Parse( Console.ReadLine());

            Console.WriteLine("học sinh {0} có điển toán là {1}, có điểm văn là {2}", hoTen, diemToan, diemVan);
            Console.ReadLine();

           
        }
    }
}
