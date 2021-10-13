using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_BAITAPTHEM
{
    class XeTai : Xe
    {
        public XeTai() : base()
        {

        }
        public XeTai(double lxang, double lhang) : base(lxang, lhang)
        {

        }
        public override void TinhXang()
        {
            double xangDung = LuongHang / 1000 + QuangDuong * 20 / 100;
            LuongXang -= xangDung;
        }
        public override bool HetXang()
        {
            if (LuongXang > 0)
            {
                return false;
            }
            return true;
        }
    }
}
