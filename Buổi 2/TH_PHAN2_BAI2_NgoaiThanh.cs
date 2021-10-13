using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_PHAN2_BAI1
{
    class TH_PHAN2_BAI2_NgoaiThanh: TH_PHAN2_BAI2_Xe
    {
        private double soNgayVanChuyen;
        private string noiDen;
        public double SoNgayVanChuyen { get => soNgayVanChuyen; set => soNgayVanChuyen = value; }
        public string NoiDen { get => noiDen; set => noiDen = value; }
        public TH_PHAN2_BAI2_NgoaiThanh()
        {
            soNgayVanChuyen = 0;
            noiDen = null;
        }
        public TH_PHAN2_BAI2_NgoaiThanh(double s, string place)
        {
            soNgayVanChuyen = s;
            noiDen = place;
        }
        public TH_PHAN2_BAI2_NgoaiThanh(string id, string name, string numXe, double quantity, double sales, double s, string place) : base(id, name, numXe, quantity, sales)
        {
            soNgayVanChuyen = s;
            noiDen = place;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap thong tin so ngay van chuyen: ");
            soNgayVanChuyen = double.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin noi den: ");
            noiDen = Console.ReadLine();
        }
        public override string ToString()
        {
            return string.Format("Thong tin chuyen xe: \n\tMa so chuyen {0}\n\tHo ten tai xe: {1}\n\tSo xe: {2}\n\tKhoi luong hang hoa: {3}\n\tDoanh thu: {4}\n\tSo ngay ban chuyen: {5}\n\tNoi den: {6}", MaSoChuyen, HoTenTaiXe, SoXe, KhoiLuongHangHoa, DoanhThu, soNgayVanChuyen, noiDen);
        }
    }
}
