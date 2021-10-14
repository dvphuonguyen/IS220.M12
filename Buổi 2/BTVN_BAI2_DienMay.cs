using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI2
{
    class DienMay : HangHoa
    {
        private string thuongHieu, loaiMay;
        private int thoiGianBaoHanh;
        public string ThuongHieu { get => thuongHieu; set => thuongHieu = value; }
        public string LoaiMay { get => loaiMay; set => loaiMay = value; }
        public int ThoiGianBaoHanh { get => thoiGianBaoHanh; set => thoiGianBaoHanh = value; }

        public DienMay() : base()
        {
            thuongHieu = loaiMay = null;
            thoiGianBaoHanh = 0;
        }
        public DienMay(string id, string name, int num, double price, string name2, string type, int time) : base(id, name, num, price)
        {
            thuongHieu = name2;
            loaiMay = type;
            thoiGianBaoHanh = time;
        }
        public override string ToString()
        {
            return base.ToString();
            return string.Format("\tThuong hieu: {0}\n\tLoai may: {1}\n\tThoi gian bao hanh: {2}\ntThanh tien: {3}\n", thuongHieu, loaiMay, thoiGianBaoHanh, ThanhTien());
        }
        public override double ThanhTien()
        {
            return base.ThanhTien() * 1.1;
        }
        public override bool Nhaphang()
        {
            if (SoLuongTK < 3)
            {
                return true;
            }
            return false;
        }
    }
}
