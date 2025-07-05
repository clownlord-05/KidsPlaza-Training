using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai24
{
    internal class Nvdc :Nhanvien
    {
        public string Ca { get; set; }
        public new double Tinhluong()
        {
            return base.Tinhluong()*1.05;
        }
    }
}
