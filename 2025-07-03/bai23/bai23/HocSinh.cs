using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai23
{
    internal class HocSinh
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //phương thức tostring
        public override string ToString()
        {
            return this.Name +"\t" +this.Email +"\t" +this.Phone;
        }
    }
}
