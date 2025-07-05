using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //chương trình không lỗi khi sử dụng tiếng việt
            Console.WriteLine("hello"); //writeline sử dụng như write nhưng có xuống dòng
            Console.WriteLine("đại học phương đông");
            Console.ReadLine(); // dừng chương trình
            Console.ReadKey(); // c2
            int soluong = 0; // khởi tạo biến
            float diemtrungbinh = 8.5f;
            string name = "tùng";
            byte tuổi;//khai báo biên
            Console.WriteLine("số lượng là:{0}", soluong);
            Console.WriteLine("so lượng là :{0},điểm trung bình là : 1", diemtrungbinh); // đặt tên biến theo kiểu diemTrungBinh
            Console.ReadLine(); //biến không được bắt đầu bằng chữ IN HOA, số đâù, kí tự đặc biệt, keyword
            int a = 1;
            int b = 2;
            float z = a / b;
            Console.WriteLine("giá trị của z là" + z);
            float z2 = (float)a/b;
            Console.WriteLine("giá trị của z2 là :" +z2);
            byte x = 255;
            int y = x; // giá trị cảu int lớn hơn byte 
            Console.ReadLine() ;
        }
    }
}
