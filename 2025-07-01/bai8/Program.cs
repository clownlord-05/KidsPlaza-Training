using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x;
            Console.WriteLine("nhập x");
            x= int.Parse(Console.ReadLine());
            while (x<1 || x>99)
            {
                Console.WriteLine("nhập lại x" ); //+x xuất ra biến x
                x= int.Parse(Console.ReadLine());
            }    
            Console.ReadLine();
        }
    }
}
