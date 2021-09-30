using System;

namespace TH_BAI5
{
    class Program
    {
        static float TienDien(float soDien)
        {
            if(soDien <= 50)
            {
                return soDien * 2000;
            }
            else if (soDien > 50 && soDien <= 100)
            {
                return 50 * 2000 + (soDien - 50) * 2500;
            }
            else
            {
                return 50 * 2000 + 50 * 2500 + (soDien - 100) * 3500;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số điện sử dụng: ");
            float soDien = float.Parse(Console.ReadLine());
            Console.WriteLine("Tiền điện phải trả là: "+ TienDien(soDien));
        }
    }
}
