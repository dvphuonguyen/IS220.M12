using System;

namespace HDTH_BAI2
{
    class HDTH_BAI2_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------------------Sach--------------------");
            Console.Write("Nhap thong tin ma sach: ");
            long maSach = long.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin ten sach: ");
            string tenSach = Console.ReadLine();
            Console.Write("Nhap thong tin don gia: ");
            double donGia = double.Parse(Console.ReadLine()); ;
            Console.Write("Nhap thong tin so luong: ");
            int soLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin nha xuat ban: ");
            string nXB = Console.ReadLine();
            HDTH_BAI2_Sach sach = new HDTH_BAI2_Sach(maSach, tenSach, donGia, soLuong, nXB);
            sach.ToString();


            Console.WriteLine("\n--------------------Sach trinh tham--------------------");
            Console.Write("Nhap thong tin ma sach: ");
            long maSach1 = long.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin ten sach: ");
            string tenSach1 = Console.ReadLine();
            Console.Write("Nhap thong tin don gia: ");
            double donGia1 = double.Parse(Console.ReadLine()); ;
            Console.Write("Nhap thong tin so luong: ");
            int soLuong1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin nha xuat ban: ");
            string nXB1 = Console.ReadLine();
            Console.Write("Nhap thong tin thue: ");
            float thue = float.Parse(Console.ReadLine());
            HDTH_BAI2_SachTrinhTham sachTrinhTham = new HDTH_BAI2_SachTrinhTham(maSach1, tenSach1, donGia1, soLuong1, nXB1, thue);
            sachTrinhTham.ToString();


            Console.WriteLine("\n--------------------Sach tieu thuyet--------------------");
            Console.Write("Nhap thong tin ma sach: ");
            long maSach2 = long.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin ten sach: ");
            string tenSach2 = Console.ReadLine();
            Console.Write("Nhap thong tin don gia: ");
            double donGia2 = double.Parse(Console.ReadLine()); ;
            Console.Write("Nhap thong tin so luong: ");
            int soLuong2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin nha xuat ban: ");
            string nXB2 = Console.ReadLine();
            Console.Write("Nhap thong tin tinh trang: ");
            bool tinhTrang = bool.Parse(Console.ReadLine());
            HDTH_BAI2_SachTieuThuyet sachTieuThuyet = new HDTH_BAI2_SachTieuThuyet(maSach2, tenSach2, donGia2, soLuong2, nXB2, tinhTrang);
            sachTieuThuyet.ToString();
        }
    }
}
