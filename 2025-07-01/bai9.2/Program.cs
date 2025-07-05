using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int thang;
            Console.WriteLine("nhập tháng:");
            thang = int.Parse(Console.ReadLine());
            int[] lst = { 1, 3, 5, 7, 6, 10, 12 }; //khởi tao 1 list
            foreach (int i in lst)
            {
                Console.WriteLine("i="+i);// if (i==3) conitune (bỏ qua nêu i=3)    
                {
                    Console.WriteLine("thang bạn chọn có 31 ngày");
                    break;
                }
                if (thang==i)
                {
                    Console.WriteLine("thang bạn chọn có 31 ngày");
                    break;
                }
       
                else
                    Console.WriteLine("tháng bạn chọn có 30 ngày");
                break;
                
            } 
            Console.ReadLine();
                
        }
    }
}
