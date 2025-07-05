using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //khởi tạo list
            List<string> ds = new List<string>(); // danh sách các phần tử là string
            List<int> ds1 = new List<int>(); // danh sách các phàn tử là số nguyên
            // khởi tạo danh sách có sẵn 1 phần tử thì các phần tử liệt kể sau {}
            List<int> ds2 = new List<int>() {1, 2, 3 };
            foreach (int i in ds2)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            //add
            List<int> ds4 = new List<int>() {1,2,3,4,5};
            ds4.Add(100);
            ds4.Add(200);
            foreach (int i in ds4)
            {
                Console.Write(i+"");
            }
            Console.WriteLine();


            //remove
            List<int> d5 = new List<int>() { 1, 2, 3, 4, 5, 67, 6 };
            Console.WriteLine("ds5:");
            foreach (int i in d5)
            {
                Console.WriteLine(i+" ");
            }
            Console.WriteLine();

            // count
            List<int> ds6 = new List<int>() { 1, 2, 3, 4, 3, 2, 1 };
            Console.WriteLine(ds6.Count);

            //clear()
            List<int> ds7 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            ds7.Clear();

            //ds8.addrange(ds9) thêm toàn bộ ds8 vào ds9
            List<int> ds8 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            List<int> ds9 = new List<int>() { 1, 3, 2, 5 };
            ds8.AddRange(ds9);
            Console.WriteLine("ds 8 ");
            foreach (int i in ds8)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            //bool <ds>,contains
            List<int> ds10 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            bool kq = ds10.Contains(10);
            Console.WriteLine(kq);

            //getrange
            List<int> ds11 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            List<int> ds12 = ds11.GetRange(1, 5);
            Console.WriteLine("ds12 :");
            foreach (int i in ds12)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //int indexof(<value>) : trả về vijtris index giá trị tìm thấy nếu không thấy trả về -1
            List<int> ds13 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            int checkIndex = ds13.IndexOf(10);// nếu trong ds có >=2 giá trị cần tìm thì vẫn trả kq về 1  
            Console.WriteLine(checkIndex);

            //ínert (ínt index, value)
            List<int> ds14 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            ds14.Insert(4, 1000);
            Console.WriteLine("ds14:");
            foreach (int i in ds14)
            {
                Console.Write(i+" ");
            }    
            Console.WriteLine();

            //insertrange(index <danh sách chèn thêm >)
            List<int> ds15 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            List<int> ds16 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            ds15.InsertRange(2, ds16);
            Console.WriteLine("ds15:");
            foreach (int i in ds15)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //removeat
            List<int> ds17 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            ds17.RemoveAt(0);
            Console.WriteLine("ds17:");
            foreach (int i in ds17)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();


            //removerange
            List<int> ds18 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            ds18.RemoveRange(2, 3);
            Console.WriteLine("ds18:");
            foreach (int i in ds18)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //<ds> reverse
            List<int> mm = new List<int>() { 1, 3, 2, 1, 4, 5 };
            mm.Reverse();
            Console.WriteLine("mm:");
            foreach (int i in mm)
            {
                Console.Write(i+" ");
            }    
            Console.WriteLine();

            //<ds>.sort
            List<int> mm1 = new List<int>() { 1, 3, 2, 1, 4, 5 };
            mm1.Sort();
            Console.WriteLine("mm1:");
            foreach(int i in mm1)
                { Console.Write(i+" "); }
            Console.WriteLine();

            //binary seacher
            int mm2 = mm1.BinarySearch(1);
            Console.WriteLine(mm2);

            //min max
            int m3 = mm1.Max();
            Console.WriteLine("giá trị lớn nhất là :"+m3);
            Console.WriteLine("giá trị nhỏ nhất là :"+ mm1.Min());
            Console.ReadLine    ();
        }
    }
}
