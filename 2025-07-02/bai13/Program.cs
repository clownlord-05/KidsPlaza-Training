using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime birday = new DateTime(2004, 12, 05 );
            Console.WriteLine("ngày  của bạn là';"+birday.ToString("dd"));
            Console.WriteLine("tháng của bạn là';"+birday.ToString("MM"));
            Console.WriteLine("năm sinh của bạn là';"+birday.ToString("yyy"));
            Console.WriteLine("ngày tháng năm sinh của bạn là';"+birday.ToString("yyy"));

            DateTime birday2 = DateTime.Parse("11/24/2004");
            Console.WriteLine("ngày tháng năm sinh 2 của bạn là';" + birday.ToString("yyy"));
            // viết chuwong trình để người dùng nhập ngày tháng năm sinh
            Console.WriteLine("ngày tháng năm sinh của bạn (tháng/ ngày / sinh )");
            string s = Console.ReadLine();
            DateTime birday3 = DateTime.Parse(s);
            Console.WriteLine("ngày  của bạn là';" + birday3.ToString("dd"));
            Console.WriteLine("tháng của bạn là';" + birday3.ToString("MM"));
            Console.WriteLine("năm sinh của bạn là';" + birday3.ToString("yyy"));
            Console.WriteLine("ngày tháng năm sinh của bạn là';" + birday3.ToString("yyy"));

        }   
    }
}
