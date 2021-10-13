using System;

namespace TH_BAI1
{
    class TH_PHAN1_BAI1_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thong tin hinh chu nhat: ");
            Console.Write("\tNhap chieu dai hinh chu nhat: ");
            int chieuDai = int.Parse(Console.ReadLine());
            Console.Write("\tNhap chieu rong hinh chu nhat: ");
            int chieuRong = int.Parse(Console.ReadLine());
            TH_PHAN1_BAI1_HinhChuNhat hinhChuNhat = new TH_PHAN1_BAI1_HinhChuNhat(chieuDai, chieuRong);
            Console.WriteLine(hinhChuNhat);
        }
    }
}
