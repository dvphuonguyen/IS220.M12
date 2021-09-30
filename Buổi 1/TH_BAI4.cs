using System;

namespace TH_BAI4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập chuỗi x: ");
            string x = Console.ReadLine();
            Console.Write("Nhập chuỗi y: ");
            string y = Console.ReadLine();

            Console.WriteLine("Tổng chiều dài chuỗi x: " + x.Length);

            Console.WriteLine("Ba ký tự đầu tiên của chuỗi x: " + x.Substring(0, 3));

            Console.WriteLine("Ba ký tự cuối của chuỗi x: " + x.Substring(x.Length - 3));

            Console.WriteLine("Ký tự thứ 6 của chuỗi " + x + " là: " + x[7]);

            if(y.Length < 3)
            {
                Console.WriteLine("Chuỗi mới gồm 3 ký tự đầu tiên của chuỗi {0} và 3 ký tự cuối của chuỗi {1} là: {2}", x, y, String.Concat(x.Substring(0, 3), y));
            }
            else
            {
                Console.WriteLine("Chuỗi mới gồm 3 ký tự đầu tiên của chuỗi {0} và 3 ký tự cuối của chuỗi {1} là: {2}", x, y, String.Concat(x.Substring(0, 3), y.Substring(y.Length - 3)));
            }

            Console.WriteLine("Hai chuỗi " + x + " và chuỗi " + y + (x.Equals(y) == true ? " bằng nhau" : " không bằng nhau"));

            Console.WriteLine(x.IndexOf(y) < 0 ? ("Chuỗi {0} không nằm trong chuỗi {1}") : ("Chuỗi {0} nằm trong chuỗi {1}"), y, x);

            int i = x.IndexOf(y);
            if (i < 0)
            {
                Console.WriteLine("Chuỗi {0} không nằm trong chuỗi {1}", y, x);
            }
            else
            {
                Console.Write("Các vị trí xuất hiện của chuỗi {0} trong chuỗi {1} là: ", y, x);
                for (; i < x.Length; i++)
                {
                    if (x.Substring(i, y.Length).Equals(y))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }    
    }
}
