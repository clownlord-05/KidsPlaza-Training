using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bài6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float diemTn;
            Console.WriteLine("nhập điểm tốt nghiệp:");
            diemTn= float.Parse(Console.ReadLine());
            if (diemTn >= 8)
                // 2 dòng lệnh cần {} để không lỗi
                Console.WriteLine("xếp loại giỏi");

            else if (diemTn >= 6.5 && diemTn < 8)
                Console.WriteLine("xếp loại khá");
            else if (diemTn >= 5 && diemTn < 6.5)
                Console.WriteLine("xếp loại yếu");
            else
                Console.WriteLine("bạn đã trượt");
            Console.ReadLine();
        }
    }
}
