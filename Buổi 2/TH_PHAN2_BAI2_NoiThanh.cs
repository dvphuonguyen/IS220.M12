using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_PHAN2_BAI1
{
    class TH_PHAN2_BAI2_NoiThanh : TH_PHAN2_BAI2_Xe
    {
        private double quangDuong;
        public double QuangDuong { get => quangDuong; set => quangDuong = value; }
        public TH_PHAN2_BAI2_NoiThanh()
        {
            quangDuong = 0;
        }
        public TH_PHAN2_BAI2_NoiThanh(double s)
        {
            quangDuong = s;
        }
        public TH_PHAN2_BAI2_NoiThanh(string id, string name, string numXe, double quantity, double sales, double s): base(id, name, numXe, quantity, sales)
        {
            quangDuong = s;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap thong tin quang duong: ");
            quangDuong = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format("Thong tin chuyen xe: \n\tMa so chuyen {0}\n\tHo ten tai xe: {1}\n\tSo xe: {2}\n\tKhoi luong hang hoa: {3}\n\tDoanh thu: {4}\n\tQuang duong: {5}", MaSoChuyen, HoTenTaiXe, SoXe, KhoiLuongHangHoa, DoanhThu, quangDuong);
        }
    }
}
