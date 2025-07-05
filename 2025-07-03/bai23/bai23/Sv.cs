using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai23
{
    public class Sv
    {
        #region biến lớp
        //khai báo biến lớp 
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion
        #region contructer
        //khai báo consreucter
        public Sv()
        {
            this.maSV = 0;
            this.tenSV = "no name";
            this.diemThiDH = 0;
        }
        
        //khởi tạo giá trị cho đối tượng
        public Sv(int maSV, string tenSv,float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSv;
            this.diemThiDH = diemThiDH;
        }
        #endregion
        #region properti
        //khai báo properti
        public string TenSV
        {
            get { return this.tenSV; } //get giá trị để đọc
            set { tenSV = value; } //set giá trị

        }
        public int MaSV
        {
            get { return this.maSV; }
            set { maSV = value; }
        }
        public float DiemThiDH
        {
            get { return diemThiDH; }
            set { diemThiDH = value; }
        }

        //support method
        private bool CheckDiemThiDH()
        {
            return(this.diemThiDH -21>=0);  
        }
        public void XuatThonTin()
        {
            if (CheckDiemThiDH()==false)
                Console.WriteLine("điểm thi <21");
            else
                Console.WriteLine(ToString());
        }
        // tổng 
        public int Tong(int x, int y)
        {
            return x*y;
        }
        public int Tong(int x, int y, int z)
        {
            return x+y+ z;
        }
        public double Tong(double x, double y, double z)
        {
            return x+y+ z;
        }

        //pramaeter list method
        public float TBKetThucHocKy(params float[] mang)
        {
            float s = 0;
            foreach (float f in mang)
            { s += f; }
            return (s / mang.Count());
        }
        
        #endregion
        #region tostring
        //phương thức tostring
        public override string ToString()
        {
            return this.MaSV + "\t" + this.TenSV;
        }
        #endregion
    }
}
