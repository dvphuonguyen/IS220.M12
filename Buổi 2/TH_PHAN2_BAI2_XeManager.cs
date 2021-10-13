using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_PHAN2_BAI1
{
    class TH_PHAN2_BAI2_XeManager
    {
        private List<TH_PHAN2_BAI2_Xe> list;
        private int soLuong;
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public List<TH_PHAN2_BAI2_Xe> List { get => list; set => list = value; }
        public TH_PHAN2_BAI2_XeManager()
        {
            soLuong = 0;
            list = new List<TH_PHAN2_BAI2_Xe>();
        }
        public TH_PHAN2_BAI2_XeManager(int size)
        {
            soLuong = size;
            list = new List<TH_PHAN2_BAI2_Xe>();
        }
        public void Nhap()
        {
            int check, choice;
            int count = 0;
            TH_PHAN2_BAI2_Xe xe;
            do
            {
                Console.WriteLine("Menu:\n\t0: Thoat\n\t1:Nhap");
                Console.Write("Nhap lua chon cua ban: ");
                check = int.Parse(Console.ReadLine());
                
                if (check == 1)
                {
                    count += 1;
                    Console.WriteLine("Menu:\n\t0: Noi thanh\n\t1: Ngoai thanh");
                    Console.Write("Nhap lua chon cua ban: ");
                    choice = int.Parse(Console.ReadLine());
                    if(choice == 0)
                    {
                        xe = new TH_PHAN2_BAI2_NoiThanh();
                    }
                    else{
                        xe = new TH_PHAN2_BAI2_NgoaiThanh();
                    }
                    xe.Nhap();
                    list.Add(xe);
                }
            } while (count < 20 && check ==1);
        }
        public void Xuat()
        {
            foreach (TH_PHAN2_BAI2_Xe xe in list)
            {
                Console.WriteLine(xe);
            }
        }
        public double TongDoanhThu()
        {
            double sum = 0;
            foreach(TH_PHAN2_BAI2_Xe xe in list)
            {
                sum += xe.DoanhThu;
            }
            return sum;
        }
        public void MaxLoaiChuyenXe()
        {
            double maxNoiThanh = -1;
            double maxNgoaiThanh = -1;
            foreach(TH_PHAN2_BAI2_Xe xe in list)
            {
                if (xe.GetType() == typeof(TH_PHAN2_BAI2_NoiThanh) && xe.DoanhThu > maxNoiThanh)
                {
                    maxNoiThanh = xe.DoanhThu;
                }
                else if (xe.GetType() == typeof(TH_PHAN2_BAI2_NgoaiThanh) && xe.DoanhThu > maxNgoaiThanh)
                {
                    maxNgoaiThanh = xe.DoanhThu;
                }
            }
            Console.WriteLine("Doanh thu lon nhat trong loai chuyen la noi thanh la: {0}", maxNoiThanh);
            Console.WriteLine("Doanh thu lon nhat trong loai chuyen la ngoai thanh la: {0}", maxNgoaiThanh);
        }
    }
}
