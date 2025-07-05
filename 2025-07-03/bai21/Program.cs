using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai21
{
    internal class Program
    {
        static void ngoaile()
        {
            try
            {
                Console.WriteLine("nhập ngày tháng năm sinh");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("ngày sinh là:" + birthday.ToString("dd/MM/yyyy"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);// xuất thông báo lỗi
            }
            finally
            {
                Console.WriteLine("ok");
            }
        }
        static void ngoaile2()
            {
            Console.WriteLine("nhập tử số");
            int tu = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập mẫu số");
            int mau = int.Parse(Console.ReadLine());
            if (mau == 0)
                throw new ArithmeticException("lỗi mẫu");
            }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ngoaile();
            try
            {
                ngoaile2();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
