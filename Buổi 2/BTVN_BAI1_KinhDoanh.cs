using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI1
{
    class BTVN_BAI1_KinhDoanh:BTVN_BAI1_KhachHang
    {
        public BTVN_BAI1_KinhDoanh() : base()
        {

        }
        public BTVN_BAI1_KinhDoanh(string id, string name, System.DateTime date, double num, double price):base(id, name, date, num, price)
        {

        }
        public override void Nhap()
        {
            base.Nhap();
        }
        public override void TinhThanhTien()
        {
            if (SoLuongDien > 400)
            {
                ThanhTien = SoLuongDien * DonGia * 1.05;
            }
            else
            {
                ThanhTien = SoLuongDien * DonGia;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
