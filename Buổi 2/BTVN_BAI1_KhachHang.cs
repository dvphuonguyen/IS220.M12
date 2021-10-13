using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI1
{
    class BTVN_BAI1_KhachHang
    {
        private string maKH, tenKH;
        private System.DateTime ngayHD;
        private double soLuongDien, donGia, thanhTien;
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public System.DateTime NgayHD { get => ngayHD; set => ngayHD = value; }
        public double SoLuongDien { get => soLuongDien; set => soLuongDien = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }

        public BTVN_BAI1_KhachHang()
        {
            maKH = tenKH = null;
            ngayHD = System.DateTime.Now;
            soLuongDien = donGia = 0;

        }
        public BTVN_BAI1_KhachHang(string id, string name, System.DateTime date, double num, double price)
        {
            maKH = id;
            tenKH = name;
            ngayHD = date;
            soLuongDien = num;
            donGia = price;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma khach hang: ");
            maKH = Console.ReadLine();
            Console.Write("Nhap ten khach hang: ");
            tenKH = Console.ReadLine();
            Console.Write("Nhap ngay: ");
            string ngay = Console.ReadLine();
            Console.Write("Nhap thang: ");
            string thang = Console.ReadLine();
            Console.Write("Nhap nam: ");
            string nam = Console.ReadLine();
            string date = thang + "/" + ngay + "/" + nam;
            ngayHD = Convert.ToDateTime(date);
            Console.Write("Nhap so luong dien: ");
            soLuongDien = double.Parse(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            donGia = double.Parse(Console.ReadLine());
            TinhThanhTien();
        }
        public virtual void TinhThanhTien()
        {
        }
        
        public override string ToString()
        {
            TinhThanhTien();
            return string.Format("Thong tin khach hang:\n\tMa khach hang: {0}.\n\tTen khach hang: {1}.\n\tNgay hoa don: {2}.\n\tSo luong dien: {3}.\n\tDon gia: {4}\n\tThanh tien: {5}.", maKH, tenKH, ngayHD, soLuongDien, donGia, thanhTien);
        }
        
    }
}
