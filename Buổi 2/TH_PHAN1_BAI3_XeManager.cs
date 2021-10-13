using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_BAI3
{
    class TH_PHAN1_BAI3_XeManager
    {
        private List<TH_PHAN1_BAI3_Xe> list;
        private int soLuong;
        public int SoLuong { get; set; }
        public List<TH_PHAN1_BAI3_Xe> List { get; set; }
        public TH_PHAN1_BAI3_XeManager()
        {
            soLuong = 0;
            list = new List<TH_PHAN1_BAI3_Xe>();
        }
        public TH_PHAN1_BAI3_XeManager(int size)
        {
            soLuong = size;
            list = new List<TH_PHAN1_BAI3_Xe>(soLuong);
        }
        public void Nhap()
        {
            string tenChuXe, loaiXe;
            double triGiaXe, dungTichXyLanh;
            do
            {
                Console.WriteLine("Nhap thong tin cua xe: ");
                Console.Write("Nhap ten chu xe: ");
                tenChuXe = Console.ReadLine();
                if(String.IsNullOrEmpty(tenChuXe)) { 
                }
               else
                {
                    Console.Write("Nhap loai xe: ");
                    loaiXe = Console.ReadLine();
                    Console.Write("Nhap tri gia xe: ");
                    triGiaXe = double.Parse(Console.ReadLine());
                    Console.Write("Nhap dung tich xy lanh: ");
                    dungTichXyLanh = double.Parse(Console.ReadLine());
                    TH_PHAN1_BAI3_Xe xe = new TH_PHAN1_BAI3_Xe(tenChuXe, loaiXe, triGiaXe, dungTichXyLanh);
                    list.Add(xe);
                }
            } while (String.IsNullOrEmpty(tenChuXe) == false);
        }
        public void Xuat()
        {
            foreach(TH_PHAN1_BAI3_Xe xe in list)
            {
                Console.WriteLine($"{xe}");
            }
        }
        public void ThueXe(string name, string type)
        {
            int count = 0;
            foreach(TH_PHAN1_BAI3_Xe xe in list)
            {
                if(String.Equals(xe.TenChuXe.ToLower(), name.ToLower())&& String.Equals(xe.LoaiXe.ToLower(), type.ToLower()))
                {
                    Console.WriteLine("Thue cua chu xe {0}, loai xe {1} la: {2}", name, type, xe.ThueDong());
                    count = 1;
                }
            }
            if(count == 0) {
                Console.WriteLine("Khong tim thay thong tin ten chu xe {0} vaf loai xe {1}", name, type);
            }
        }
    }
}
