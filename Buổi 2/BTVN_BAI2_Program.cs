using System;

namespace BTVN_BAI2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Nhap--------");
            HangHoaManager hangHoaManager = new HangHoaManager();
            hangHoaManager.Nhap();
            Console.WriteLine("--------Xuat--------");
            hangHoaManager.XuatNhapHang();
        }
    }
}
