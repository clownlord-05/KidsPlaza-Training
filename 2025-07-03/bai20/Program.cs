using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20
{
    internal class Program
    {   
        static int Tong(int x, int y, int z)
        {
            return x + y + z;
        }
        //gai thừa
        static int TinhGiaiThua (int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
                gt *= i;
            return gt;
        }
        //vd static void
        static void hello(string m)
        {
            if (m == "xhao")
                Console.WriteLine("hello world");
            if (m == "hi")

                Console.WriteLine("chao");
        }
        // truyền tham trị
        static void thamtri(int a)
        {
            a = a + 1;
            Console.WriteLine(" giá trị a trong hàm là:"+a);
        }
        static void thamchieuref(ref  int b)
        {
            b++;
            Console.WriteLine("b trong hàm: " + b);
        }
        static void thamchieuout(out int c)
        {
            c = 5;
            Console.WriteLine("c trong hàm là:"+c);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int kq = Tong(1,2,3);


            //xuất giai thua
            int k = 3;
            int kq2 = TinhGiaiThua(k);
            Console.WriteLine("kq2="+kq2);

            hello("xhao");
            hello("hi");

            // truyền tham trị
            int a = 1;
            Console.WriteLine("a trước khi gọi:"+a);
            thamtri(a);
            Console.WriteLine("a sau gọi"+a);

            // ref
            int b = 2;// dùng ref bắt buộc gán giá trị
            Console.WriteLine("b trước gọi hàm"+b);
            thamchieuref(ref b);
            Console.WriteLine("b sau gọi hàm"+b);

            //out
            int c;
            thamchieuout (out c);
            Console.WriteLine("c sau gọi"+c);
            Console.ReadLine();
        }
    }
}
