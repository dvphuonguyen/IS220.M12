using System;

namespace TH_BAITAPTHEM
{
    class TH_BAITAPTHEM_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Nhap-------");
            Console.Write("Nhap so luong xe: ");
            int soLuong = int.Parse(Console.ReadLine());
            TH_BAITAPTHEM_XeManager xeManager = new TH_BAITAPTHEM_XeManager(soLuong);
            xeManager.Nhap();
            Console.WriteLine("-------Xuat-------");
            xeManager.XuatLuongXangDaDo();
        }
    }
}
