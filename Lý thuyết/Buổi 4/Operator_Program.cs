using System;

namespace TaiLop
{
    class Program_OPER
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PhanSo fraction1 = new PhanSo();
            Console.WriteLine("Nhập thông tin cho phân số thứ nhất: ");
            fraction1.Nhap();
            PhanSo fraction2 = new PhanSo();
            Console.WriteLine("Nhập thông tin cho phân số thứ hai: ");
            fraction2.Nhap();
            PhanSo fraction3 = new PhanSo();
            fraction3 = fraction1 + fraction2;
            Console.WriteLine("Tổng hai phân số là: " + (fraction3));
            fraction3 = fraction1 - fraction2;
            Console.WriteLine("Hiệu hai phân số là: " + (fraction3));
            fraction3 = fraction1 * fraction2;
            Console.WriteLine("Tích hai phân số là: " + (fraction3));
            fraction3 = fraction1 / fraction2;
            Console.WriteLine("Thương hai phân số là: " + (fraction3));
            if(fraction1 == fraction2)
            {
                Console.WriteLine("Hai phân số bằng nhau");
            }
            else
            {
                Console.WriteLine("Hai phân số khác nhau");
            }
            if (fraction1 != fraction3)
            {
                Console.WriteLine("Hai phân số khác nhau");
            }
            else
            {
                Console.WriteLine("Hai Hai phân số bằng nhau");
            }
        }
    }
}
