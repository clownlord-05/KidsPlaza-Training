using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] stt;
            char[] ch;
            string [] ten ;
            stt = new int[5];
                foreach (int i in stt)
            {
                Console.WriteLine(i+ " ");

            }
            Console.WriteLine();
            Console.WriteLine("mảng stt2 là :");
            int[] stt2 = new int[7];
            foreach (int i in stt2)
            {
                Console.WriteLine(i+ " ");
            }
               
            Console.ReadLine();

                
                

        }
    }
}
