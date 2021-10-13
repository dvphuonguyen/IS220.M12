using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI1
{
    class BTVN_BAI1_SanXuat : BTVN_BAI1_KhachHang
    {
        private BTVN_BAI1_LoaiDien loaiDien;
        public BTVN_BAI1_LoaiDien LoaiDien { get => loaiDien; set => loaiDien = value; }
        public BTVN_BAI1_SanXuat() : base()
        {

        }
        public BTVN_BAI1_SanXuat(BTVN_BAI1_LoaiDien lDien)
        {
            loaiDien = lDien;
        }
        public BTVN_BAI1_SanXuat(string id, string name, System.DateTime date, double num, double price, BTVN_BAI1_LoaiDien lDien) : base(id, name, date, num, price)
        {
            loaiDien = lDien;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Chon loai dien: \n\t0: Hai pha\n\t1:Ba pha\n");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 0)
            {
                loaiDien = new BTVN_BAI1_HaiPha();
            }
            else
            {
                loaiDien = new BTVN_BAI1_BaPha();
            }
        }
        public override void TinhThanhTien()
        {
            if (loaiDien.GetType()==typeof(BTVN_BAI1_HaiPha))
            {
                ThanhTien = SoLuongDien * DonGia *loaiDien.PhanTram(SoLuongDien, DonGia);
            }
            else 
            {
                ThanhTien = SoLuongDien * DonGia * loaiDien.PhanTram(SoLuongDien, DonGia);
            }
        }
        /*
        public override string ToString()
        {
            return base.ToString();
            return string.Format("\n\tLoai dien: {0}", loaiDien);
        }
        */
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
