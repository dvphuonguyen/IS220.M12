using System;

namespace TH_PHAN2_BAI1
{
    class TH_PHAN2_BAI2_Program
    {
        static void Main(string[] args)
        {
            TH_PHAN2_BAI2_XeManager list = new TH_PHAN2_BAI2_XeManager();
            Console.WriteLine("---------------Nhap---------------");
            list.Nhap();
            Console.WriteLine("---------------Xuat---------------");
            list.Xuat();
            Console.WriteLine("---------------Tong doanh thu---------------");
            Console.WriteLine("Tong doanh thu la: {0}", list.TongDoanhThu());
            Console.WriteLine("---------------Doanh thu cao nhat---------------");
            list.MaxLoaiChuyenXe();
        }
    }
}
