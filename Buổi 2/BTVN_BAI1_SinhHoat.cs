using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI1
{
    class BTVN_BAI1_SinhHoat : BTVN_BAI1_KhachHang
    {
        private double dinhMuc;
        public double DinhMuc { get => dinhMuc; set => dinhMuc = value; }
        public BTVN_BAI1_SinhHoat() : base()
        {

        }
        public BTVN_BAI1_SinhHoat(double dMuc)
        {
            dinhMuc = dMuc;
        }
        public BTVN_BAI1_SinhHoat(string id, string name, System.DateTime date, double num, double price, double dMuc) : base(id, name, date, num, price)
        {
            dinhMuc = dMuc;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap dinh muc: ");
            dinhMuc = double.Parse(Console.ReadLine());
        }
        public override void TinhThanhTien()
        {
            if(SoLuongDien < dinhMuc)
            {
                ThanhTien = SoLuongDien * DonGia;
            }
            else{
                ThanhTien = SoLuongDien * DonGia * dinhMuc + (SoLuongDien - dinhMuc) * DonGia * 2;
            }
        }
        /*
        public override string ToString()
        {
            return base.ToString();
            return string.Format("\n\tDinh muc: {0}", dinhMuc);
        }
        */
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
