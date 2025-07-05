using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //mảng 2 chiều
            int[,] arr = new int[2, 4]; //2 hàng 4 cột

            // khởi tạo và gán giá trị
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //hập giá trị cho mảng dùng 2 vòng for
            Random r = new Random();
            int dong = 3;
            int cot = 4;    
            int[,] arr3 = new int[dong,cot];
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    //Console.Write(i);
                    //Console.Write(j + "\t");
                    arr3[i, j] = r.Next(51);
                }
                Console.WriteLine();
            }
            Console.WriteLine(arr3[0,0]);
            Console.WriteLine(arr3[0,1]);
            Console.WriteLine(arr3[0,2]);

            for (int i = 0;i<arr3.GetLength(0);i ++)
            {
                for (int j = 0;j<arr3.GetLength(1);j++)
                {
                    Console.Write(arr3[i,j]+"\t");
                }
                Console.WriteLine();
            }    
            Console.ReadLine();



        }
    }
}
