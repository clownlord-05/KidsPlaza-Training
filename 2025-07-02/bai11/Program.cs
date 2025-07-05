using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pi=" +Math.PI);
            Console.WriteLine("kiểu dữ liệu của math.pi là:" +Math.PI.GetType().ToString());
            double pi = (float) Math.PI;
            Console.WriteLine("pi sau khi ép kiểu float =" +pi);
            // căn bậc 2
            int a = 4;
            Console.WriteLine("căn bậc 2 của a= " +Math.Sqrt(a));
            Console.WriteLine("kiểu dữ kiệu của sqrt là : " +Math.Sqrt(a).GetType().ToString());
            // lũy thùa
            Console.WriteLine("2luyx thùa 3 = " +Math.Pow(2,3));
            //max
            Console.WriteLine("max= " +Math.Max(2,3)); // min tương tự thay max thành min
            // làm tròn
            float c = 1.23456789f;
            Console.WriteLine("số c sau khi làm tròn 2 số : " +Math.Round(c,2));
            // sin 
            Console.WriteLine("sin của 180= " +Math.Sin(30*Math.PI/180));
            Console.ReadLine();
        }
     
    }
}
