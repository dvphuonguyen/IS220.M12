using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_BAITAPTHEM
{
    class TH_BAITAPTHEM_XeManager
    {
        private int soLuong;
        private List<TH_BAITAPTHEM_Xe> list;
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public List<TH_BAITAPTHEM_Xe> List { get => list; set => list = value; }
        public TH_BAITAPTHEM_XeManager()
        {
            soLuong = 0;
            list = new List<TH_BAITAPTHEM_Xe>();
        }
        public TH_BAITAPTHEM_XeManager(int size)
        {
            soLuong = size;
            list = new List<TH_BAITAPTHEM_Xe>(size);
        }
        public void Nhap()
        { 
            double luongXang, luongHang, quangDuong;
            for(int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("------Nhap thong tin xe thu {0}: ", i);
                Console.Write("Nhap luong xang: ");
                luongXang = double.Parse(Console.ReadLine());
                Console.Write("Nhap luong hang: ");
                luongHang = double.Parse(Console.ReadLine());
                Console.Write("Nhap quang duong: ");
                quangDuong = double.Parse(Console.ReadLine());
                Console.WriteLine("Menu:\n\t1:Xe may\n\t2:Xe tai");
                Console.Write("Nhap lua chon cua ban: ");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    list.Add(new TH_BAITAPTHEM_XeMay(luongXang, luongHang, quangDuong));
                }
                else
                {
                    list.Add(new TH_BAITAPTHEM_XeTai(luongXang, luongHang, quangDuong));
                }
            }
        }
        public void XuatLuongXangDaDo()
        {
            Console.WriteLine("Luong xang da do cua tung xe la: ");
            double hienTai;
            foreach(TH_BAITAPTHEM_Xe xe in list)
            {
                hienTai = xe.LuongXang;
                xe.TinhXang();
                if (xe.GetType() == typeof(TH_BAITAPTHEM_XeMay))
                {
                    Console.WriteLine("\tLuong xang da do cua xe may la: {0}", xe.LuongXang - hienTai + (xe.LuongHang * 0.1 / 10 + xe.QuangDuong * 2 / 100));
                }
                else
                {
                    Console.WriteLine("\tLuong xang da do cua xe tai la: {0}", xe.LuongXang - hienTai + (xe.LuongHang / 1000 + xe.QuangDuong * 20 / 100));
                }
            }
        }
    }
}
