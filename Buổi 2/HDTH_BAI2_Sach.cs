using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDTH_BAI2
{
    class HDTH_BAI2_Sach
    {
        private long maSach;
        private string tenSach;
        private double donGia;
        private int soLuong;
        private string nXB;
        public long MaSach
        {
            get => maSach;
            set { maSach = value; }

        }
        public string TenSach
        {
            get => tenSach;
            set { tenSach = value; }
        }
        public double DonGia
        {
            get => donGia;
            set { donGia = value; }
        }
        public int SoLuong
        {
            get => soLuong;
            set { soLuong = value; }
        }
        public string NXB
        {
            get => nXB;
            set { nXB = value; }
        }


        public HDTH_BAI2_Sach()
        {
            maSach = 0;
            tenSach = null;
            donGia = 0;
            soLuong = 0;
            nXB = null;

        }
        public HDTH_BAI2_Sach(long id, string name, double price, int size, string publish)
        {
            maSach = id;
            tenSach = name;
            donGia = price;
            soLuong = size;
            nXB = publish;
        }
        public virtual void ToString()
        {
            Console.Write("Thong tin sach:\n\tMa sach: {0}\n\tTen sach: {1}\n\tDon gia: {2}\n\tSo luong: {3}\n\tNha xuat ban: {4}\n\tThanh tien: {5}", maSach, tenSach, donGia, soLuong, nXB, ThanhTien());
        }

        public virtual double ThanhTien()
        {
            return donGia * soLuong;
        }
    }
}
