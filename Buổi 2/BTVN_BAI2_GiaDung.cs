using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI2
{
    class GiaDung:HangHoa
    { 
        private string nhaSanXuat, loaiGiaDung;
        private DateTime ngayNhap;
        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
        public string LoaiGiaDung { get => loaiGiaDung; set => loaiGiaDung = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }

        public GiaDung(): base()
        {

        }
        public GiaDung(string id, string name, int num, double price, string name2, string type, DateTime time): base(id, name, num, price)
        {
            nhaSanXuat = name2;
            loaiGiaDung = type;
            ngayNhap = time;
        }
        public override string ToString()
        {
            return base.ToString();
            return string.Format("\tNha san xuat: {0}\n\tLoai gia dung: {1}\n\tNgay nhap: {2}\n", nhaSanXuat, loaiGiaDung, ngayNhap);
        }
        public override bool Nhaphang()
        {
            if (SoLuongTK < 5)
            {
                return true;
            }
            return false;
        }

    }
}
