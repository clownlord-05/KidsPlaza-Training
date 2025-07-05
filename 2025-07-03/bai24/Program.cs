using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Nhanvien nv1 = new Nhanvien();
            nv1.TenNV = "nhân viên 1";
            nv1.MaNV = 1;
            Console.WriteLine("tên nhân viên: "+nv1.TenNV + "mã nhân viên: " +nv1.MaNV);
            Console.WriteLine("lương nhân viên 1 là:"+nv1.Tinhluong());
            Nvhc hc1 = new Nvhc();
            hc1.TenNV = "hành chính";
            hc1.MaNV = 2;
            Console.WriteLine("tên nhân viên là: " +hc1.TenNV+"mã nhân viên: "+hc1.MaNV);
            Console.WriteLine("lương nhân viên 1 là:" + hc1.Tinhluong());
            Nvdc ca1 = new Nvdc();
            ca1.TenNV = "nguyễn ab";
            ca1.MaNV = 3;
            ca1.Ca = "ca ngày";
            Console.WriteLine("tên nhân viên là: " + ca1.TenNV + "mã nhân viên: " + ca1.MaNV+ " đi làm ca "+ca1.Ca);
            Console.WriteLine("lương nhân viên ca1 là:" + ca1.Tinhluong());

            Console.WriteLine(nv1.Thuongducong(26));
            Console.WriteLine(hc1.Thuongducong(26));
            Console.WriteLine(ca1.Thuongducong(26));
            Console.ReadKey();
        }
    }
}
