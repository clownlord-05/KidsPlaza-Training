using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai24
{
    internal class Nhanvien
    {
        // khởi tạo 
        public int MaNV { get; set; }
        public string TenNV { get; set; }

        //phương thức tính lương
        public double Tinhluong()
        {
            return 1000;
        }
        // hàm ảo virtual
        public virtual double Thuongducong(int ngaycong)
        {
            if (ngaycong >= 26)
                return 100;
            else
                return 0;
        }

    }
}
