using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] stt;// khai báo mảng
            string[] ten;

            stt = new int[5]; // tên mảng = new kieudulieu[sophantu];
            foreach (int i in stt)
            {
                Console.Write(i+ " ");
            }
            // cách 2
            Console.WriteLine();
            Console.WriteLine("mang st2 là:");
            int[] st2 = new int[7];
            foreach (int i in st2)
            {
                Console.Write(i+ " ");
            }


            // khởi tạo vào gán giá trị
            int[] ten2 = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine();
            Console.Write("mảng 3 là:");
            foreach (int i in ten2)
            {
                Console.WriteLine(i+ " ");
            }

            //khởi tạo mảng random
            Random r = new Random();
            int[] st3 = new int[2] {r.Next(51),r.Next(61)};
            Console.WriteLine();
            Console.WriteLine("mảng 3 là:");
            foreach(int i in st3)
            {
                Console.Write(i+ " ");
            }

            //length
            Console.WriteLine();
            int dai = st3.Length;
            Console.WriteLine(dai);

            //truy xuất phần tử qua index
            int[] mang4 = { 1, 3, 4 };
            Console.WriteLine(mang4[0]);
            Console.WriteLine(mang4[1]);
            Console.WriteLine(mang4[mang4.Length-1]);

            //thay đổi giá trị phần tử 
            int[] mang5 = { 1, 3,4 ,5 ,6};
            mang5[1] = 100;
            Console.WriteLine("mảng 5 sau khi đổi giá trị:");
            foreach (int i in mang5)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            //duyệt mảng for (duyệt theo index)
            int[] mang6 = { 1, 3,5 ,6 , 7};
            for (int i = 0; i < mang6.Length; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine(mang6[i]);
            }
            Console.WriteLine();
            
            //gán mảng

            int[] mang8 = { 1, 3,5 ,7 };
            int[] mang9 = mang8;
            mang8[0] = 100; 
            Console.WriteLine("mảng 8 sau khi đổi index tại 0:" + mang8[0]);
            Console.WriteLine("mảng 9 sau khi đổi index tại 0:" + mang9[0]);

            //copy to
            int[] mang10 = { 1000, 344,53,52,100,200 };
            int[] mang11 = { 1,2,3,4,5,6,7,8,9}; //mảng được copy vào từ vị trí chèn phải >= mảng copy
            mang10.CopyTo(mang11, 1);
            Console.WriteLine("mảng 11 sau copy là :");
            foreach (int i in mang11)
                
            {
                Console.WriteLine(i +" ");
            }
            Console.WriteLine();

            //copy
            int[] mang12 = { 1, 2, 3, 4, 5, 6 };
            int[] mang13 = new int[5];
            Array.Copy(mang12, mang13, 5);
            Console.WriteLine("mang 13 là :");
            foreach(int i in mang13)
            {
                Console.Write(i +" ");
            }  
            Console.WriteLine();

            // clone
            int[] mang14 = { 1, 2,3, 4, 5,6 };
            int[] mang15 = (int[])mang14.Clone();
            Console.WriteLine("mang 15 là:");
            foreach(int i in mang15)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();

            //reverse : đảo ngược mảng

            int [] mang16 = {1,3,4,5,6,7,8,10};
            Array.Reverse(mang16);
            Console.WriteLine("mang 16 là :");
            foreach(int i in mang16)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();

            // arry.sort  : xắp xếp tăng dần
            int[] mang17 = {1,3,4,5,9,100,438,352542,7,8,10};
            Array.Sort(mang17);
            Console.WriteLine("mang 17 :");
            foreach (int i in mang17)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
