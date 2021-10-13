using System;

namespace HDTH_BAI1
{
    class HDTH_BAI1_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thong tin tai khoan:");
            Console.Write("\tNhap thong tin so tai khoan:");
            long soTK = long.Parse(Console.ReadLine());
            Console.Write("\tNhap thong tin ten tai khoan:");
            string tenTK = Console.ReadLine();
            Console.Write("\tNhap thong tin so tien:");
            double soTien = double.Parse(Console.ReadLine());
            HDTH_BAI1_TaiKhoan taiKhoan = new HDTH_BAI1_TaiKhoan(soTK, tenTK, soTien);
            Console.WriteLine(taiKhoan);
            Console.Write("Nhap so tien can nap:");
            double tienNap = double.Parse(Console.ReadLine());
            if (taiKhoan.NapTien(tienNap))
            {
                Console.WriteLine("Nap tien thanh cong");
            }
            else
            {
                Console.WriteLine("Nap tien that bai");
            }
            if (taiKhoan.RutTien())
            {
                Console.WriteLine("Rut tien thanh cong");
            }
            else
            {
                Console.WriteLine("Rut tien that bai");
            }
        }
    }
}
