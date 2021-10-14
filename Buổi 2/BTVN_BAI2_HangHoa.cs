using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI2
{
    class HangHoa
    {
        private string maHH, tenHH;
        private int soLuongTK;
        private double donGia;
        public string MaHH { get => maHH; set => maHH = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        public int SoLuongTK { get => soLuongTK; set => soLuongTK = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public HangHoa()
        {
            maHH = tenHH = null;
            soLuongTK = 0;
            donGia = 0;
        }
        public HangHoa(string id, string name, int num, double price)
        {
            maHH = id;
            tenHH = name;
            soLuongTK = num;
            donGia = price;
        }
        public override string ToString()
        {
            return string.Format("Thong tin hang hoa:\n\tMa hang hoa: {0}\n\tTen hang hoa:{1}\n\tSo luong trong kho: {2}\n\tDon gia: {3}\n", maHH, tenHH, soLuongTK, donGia);
        }
        public virtual double ThanhTien() 
        { 
            return soLuongTK*donGia; 
        }
        public virtual bool Nhaphang()
        {
            return true;
        }
    }
}
