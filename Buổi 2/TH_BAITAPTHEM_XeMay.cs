using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_BAITAPTHEM
{
    class XeMay:Xe
    {
        public XeMay() : base()
        {

        }
        public XeMay(double lxang, double lhang):base(lxang, lhang)
        {

        }
        public override void TinhXang()
        {
            double xangDung = LuongHang * 0.1 / 10 + QuangDuong * 2 / 100;
            LuongXang -= xangDung;
        }
        public override bool HetXang()
        {
            if(LuongXang > 0)
            {
                return false;
            }
            return true;
        }
    }
}
