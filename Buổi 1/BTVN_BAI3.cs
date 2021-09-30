using System;

namespace BTVN_BAI3
{
    class Program
    {
        static void UocSo(int n)
        {
            int count = 0;
            Console.WriteLine("Liet ke: ");
            for(int i = 1; i < n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("\t{0} la uoc cua {1}", i, n);
                    count += 1;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Khong co");
            }
        }
        static void Main(string[] args)
        {
            int soNguyen;
            do
            {
                Console.WriteLine("Nhap so nguyen duong: ");
                soNguyen = int.Parse(Console.ReadLine());
            } while (soNguyen < 1);
            UocSo(soNguyen);
        }
    }
}
