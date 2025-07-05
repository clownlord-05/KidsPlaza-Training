using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char ch1 = 'a';
            Console.WriteLine(ch1);
            Console.WriteLine(ch1.GetType().ToString());
            Console.ReadKey();

            char ch2 = (char)64; //ascii char64=@
            Console.WriteLine(ch2);
            Console.WriteLine(ch2.GetType().ToString());
            Console.ReadKey();

            char ch3 = char.Parse("b"); // ""-> string
            Console.WriteLine(ch3);
            Console.WriteLine(ch3.GetType().ToString());
            Console.ReadKey();

            char ch4 = Convert.ToChar("t");
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetType().ToString());
            Console.ReadKey();

            char ch5 = 'c';
            char ch6 = 'a';
            char ch7 = 'b';
            char ch8 = 'm';
            Console.WriteLine(ch5.CompareTo(ch6));
            Console.WriteLine(ch6.CompareTo(ch5));
            Console.WriteLine(ch5.CompareTo(ch7));

            Console.WriteLine(ch5.Equals(ch6));
            Console.WriteLine(ch5.Equals(ch7));

            //char method in c#
            Console.WriteLine(char.IsDigit('2')); //true
            Console.WriteLine(char.IsLetter('b'));// true
            Console.WriteLine(char.IsWhiteSpace( ' ' ));
            Console.WriteLine(char.IsLower('a')); // ki tự viết thường
            Console.WriteLine(char.IsUpper('A'));// kí tự viết hoa
            Console.WriteLine(char.ToUpper('a'));//chuyển thường sang hoa
            Console.WriteLine(char.ToLower('B'));//chuyển hoa sang thường
        }

    }
}
