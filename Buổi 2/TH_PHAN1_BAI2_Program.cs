using System;

namespace TH_BAI2
{
    class TH_PHAN1_BAI2_Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int soLuong = int.Parse(Console.ReadLine());
            TH_PHAN1_BAI2_StudentManager list = new TH_PHAN1_BAI2_StudentManager(soLuong);
            for(int i = 0; i<soLuong; i++)
            {
                Console.Write("-------------Nhap thong tin sinh vien {0}: -------------\n", i);
                TH_PHAN1_BAI2_Student sinhVien = new TH_PHAN1_BAI2_Student();
                sinhVien.Nhap();
                list.Nhap(sinhVien);
            }
            list.Xuat();
        }
    }
}
