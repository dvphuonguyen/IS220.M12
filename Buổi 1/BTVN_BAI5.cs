using System;

namespace BTVN_BAI5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen: ");
            int soNguyen = int.Parse(Console.ReadLine());
            if (soNguyen <= 0) ;
            else
            {
                Console.WriteLine("Liet ke: ");
                int count = 0;
                for(int i = 0; i < soNguyen; i++)
                {
                    if(i %2 == 1)
                    {
                        Console.WriteLine("\t{0} la so le tu 0 - {1}", i, soNguyen);
                        count += 1;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine("Khong co");
                }
            }
        }
    }
}
