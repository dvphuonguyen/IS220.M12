using System;

namespace TH_BAI3
{
    class TH_PHAN1_BAI3_Program
    {
        static void Main(string[] args)
        {
            TH_PHAN1_BAI3_XeManager list = new TH_PHAN1_BAI3_XeManager();
            Console.WriteLine("-----------Nhap-----------");
            list.Nhap();
            Console.WriteLine("-----------Xuat-----------");
            list.Xuat();
            Console.WriteLine("-----------Tim thue phai dong-----------");
            Console.Write("Nhap ten chu xe can tim: ");
            string tenChuXe = Console.ReadLine();
            Console.Write("Nhap loai xe can tim: ");
            string loaiXe = Console.ReadLine();
            list.ThueXe(tenChuXe, loaiXe);
        }
    }
}
