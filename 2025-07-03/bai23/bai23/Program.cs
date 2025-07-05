using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace bai23
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
            Console.WriteLine("tên sinh viên là :" + sinhvien.TenSV);
            //service method & support method
            Sv sinhvien3 = new Sv(3,"nmt",20);
            //check điểm    
            Console.WriteLine(sinhvien3.Tong(1, 2));

            //paremetter list method
            Console.WriteLine(sinhvien2.TBKetThucHocKy(1, 2, 3, 4, 5));
            Console.WriteLine(sinhvien2.TBKetThucHocKy(3, 4, 5, 6, 7, 8)); 

            HocSinh hocSinh = new HocSinh();
            hocSinh.Name = "t";
            hocSinh.Phone = "123";
            hocSinh.Phone = "t123@gmail.com";
            Console.WriteLine(hocSinh);

           
            Console.ReadKey();
        }
    }
}
