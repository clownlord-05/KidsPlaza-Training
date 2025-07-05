using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
          //tạo đối tượng mới nhưng không truyền giá trị
            Sv sinhvien = new Sv();
            Sv sinhvien2 = new Sv();

            //xuất
            Console.WriteLine(sinhvien.MaSV);
            Console.WriteLine(sinhvien2.MaSV);
            Console.WriteLine(sinhvien.TenSV);
            Console.WriteLine(sinhvien2.TenSV);
            Console.WriteLine("tên sinhv viên là :"+sinhvien.TenSV);
            //tạo đối tượng gán giá trị
            Sv sinhvien3 = new Sv(3, "nguyễn mạnh tùng");
            Console.WriteLine("tên sinh viên 3 là :"+sinhvien3.TenSV);

            // sửa dữ liệu
            sinhvien3.MaSV = 123;
            sinhvien3.TenSV = "nmt";
            Console.WriteLine("mã sv 3 :"+sinhvien3.MaSV);
            Console.WriteLine("tên sv 3 :"+sinhvien3.TenSV);
            Console.ReadKey();
        }
    }
}
