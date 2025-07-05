using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    public class Sv
    {
        //khai báo biến lớp 
        private int maSV;
        private string tenSV;

        //khai báo consreucter
        public Sv()
        {
            this.maSV = 0;
            this.tenSV = "no name";
        }
        //khởi tạo giá trị cho đối tượng
        public Sv(int maSV, string tenSv)
        {
          this.maSV = maSV;
          this.tenSV = tenSv; 
        }
        //khai báo properti
        public string TenSV
        {
            get { return this.tenSV; } //get giá trị để đọc
            set { tenSV = value; } //set giá trị

        }
        public int MaSV
        { get { return this.maSV; }
          set { maSV = value; }
        }
    }
}
