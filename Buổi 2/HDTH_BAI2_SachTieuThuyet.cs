using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDTH_BAI2
{
    class HDTH_BAI2_SachTieuThuyet:HDTH_BAI2_Sach
    {
        private bool tinhTrang;
        public bool TinhTrang
        {
            get => tinhTrang;
            set { tinhTrang = value; }

        }
        public HDTH_BAI2_SachTieuThuyet()
        {
            tinhTrang = true;
        }
        public HDTH_BAI2_SachTieuThuyet(bool state)
        {
            tinhTrang = state;
        }
        public HDTH_BAI2_SachTieuThuyet(long id, string name, double price, int size, string publish, bool state) : base(id, name, price, size, publish)
        {
            tinhTrang = state;
        }
        public override void ToString()
        {
            base.ToString();
            Console.Write("\n\tTinh trang: " + tinhTrang);

        }
        public override double ThanhTien()
        {

            if (tinhTrang == true)
            {
                return base.ThanhTien();
            }
            else
            {
                return base.ThanhTien() * 0.2;
            }
        }
    }
}
