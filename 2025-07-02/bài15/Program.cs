using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //khai báo chuỗi
            string chuoi = "mạnh tùng";
            Console.WriteLine("chuỗi là: " +chuoi);

            //khai báo nguyên văn @
            string chuoi1 = @"C:\MANHTUNG";
            string chuoi2 = " \"If you're not a good shot today, don't worry. There are other ways to be useful.\"";
            Console.WriteLine("chuỗi 1 là: "+chuoi1);
            Console.WriteLine(chuoi2);

            //chuyển đổi sangg chuỗi
            int i = 123123;
            string chuoi3 = i.ToString();
            Console.WriteLine(chuoi3);

            //tách chuỗi thành kí tự lẻ cho vào mảng
            string chuoi4 = "hà nội";
            char[] lst = chuoi4.ToCharArray();
            Console.WriteLine(lst);
            Console.WriteLine(lst.GetType().ToString()); // check kiểu loại

            // length
            string chuoi5 = "test";
            int j= chuoi5.Length;
            Console.WriteLine(j);
            Console.WriteLine("kí tự 2 của chuỗi:" + chuoi5[1]);

            int ds = 0, dct = 0, dih=0,dspace =0;
            string chuoi6 = "love  is";
            char[] lst1=chuoi6.ToCharArray();
            foreach(char c in lst1)
            {
                Console.WriteLine(c);
                if (char.IsDigit(c))
                    ds++;
                else if (char.IsLower(c))
                    dct++;
                else if (char.IsUpper(c))
                    dih++;
                else if (char.IsWhiteSpace(c))
                    dspace++;
            }
            Console.WriteLine("chuỗi có {0} kí tự viết thường", dct);
            Console.WriteLine("chuỗi có {0} kí tự viết hoa", dih);
            Console.WriteLine("chuỗi có {0} kí tự viết cách", dspace);
            Console.WriteLine("chuỗi có {0} kí tự viết số", ds);

            // so sánh chuỗi
            string chuoi7 = "123123456a";
            string chuoi8 = "123156a";
            int sosanh = chuoi8.CompareTo(chuoi7);
            Console.WriteLine(sosanh);

            // kiểm tra chuỗi con
            string chuoi9 = "abc";
            string chuoi10 = "1234abcdfsf";
            bool l=chuoi10.Contains(chuoi9);
            Console.WriteLine(l);

            // hàm copyto
            string chuoi11 = "1234567";
            char[] lst2 = new char[6]; // tạo ra mảng có độ dài 6
            lst2[0] = 'a';
            lst2[1] = 'b';
            Console.WriteLine(lst2);
            chuoi11.CopyTo(1, lst2, 2, 4);
            Console.WriteLine(lst2);

            //endswith hàm bool 
            string chuoi12 = "nguyenmanhtung.mp4";
            bool kt= chuoi12.EndsWith(".mp4");

            //gán chuỗi theo string.format
            int m = 14;
            string chuoi13 = string.Format("m={0}và căn bậc 2 của m là {1}", m, Math.Sqrt(m));
            Console.WriteLine(chuoi13);

            // hàm bool equals
            string chuoi14 = "hanoi";
            string chuoi15 = "hanoi";
            bool kt2 = chuoi14 .Equals(chuoi15);
            Console.WriteLine(kt2);

            //chèn thêm vào chuỗi
            string chuoi16 = "abc";
            string chuoi17 = "123";
            chuoi16 = chuoi16.Insert (3,chuoi17);
            Console.WriteLine(chuoi16);

            //indexof
            string chuoi18 = "123abcafg";
            int kq = chuoi18.IndexOf('a');
            Console.WriteLine(kq);
      

            //lastindexof
            string chuoi19 = "hanoi";
            int kq1 = chuoi19.LastIndexOf('a');
            Console.WriteLine(kq1);

            //remove 
            string chuoi20 = "123456";
            chuoi20 = chuoi20.Remove(1,2);
            Console.WriteLine(chuoi20);

            //replace
            string chuoi21 = "123445674489";
            chuoi21 = chuoi21.Replace("44", "ab");
            Console.WriteLine(chuoi21);

            //starswith
            string chuoi22 = "nguyenmanhtung,mp4";
            bool kt4 = chuoi22.StartsWith("nguyen");
            Console.WriteLine(chuoi22);

            // substring
            string chuoi23 = "123456";
            string chuoi24 = chuoi23.Substring(2,3);
            Console.WriteLine(chuoi24);

            //tolower
            string chuoi25 = "ABcfgk";
            Console.WriteLine(chuoi25);
            chuoi25 = chuoi25.ToLower();// chuyển chuỗi sang thường ngược lại dùng touper
            Console.WriteLine(chuoi25);

            //trim
            string chuoi26 = "    bbv   ";
            chuoi26 = chuoi26.Trim();//xóa space đầu đuổi
            Console.WriteLine(chuoi26);
            // trimend và trimstart xóa space cuối và đầu

            //split tách phần tử
            string chuoi27 = "mot,hai,ba";
            string [] lst4 = chuoi27.Split(',');
            Console.WriteLine(lst4[0]);
            Console.WriteLine(lst4[1]);
            Console.WriteLine(lst4[2]);

            //jointstring nối phần tử 
            string chuoi28 = string.Join(",", lst4);
            Console.WriteLine(chuoi28);
 
            Console.ReadLine();
        }
    }
}
