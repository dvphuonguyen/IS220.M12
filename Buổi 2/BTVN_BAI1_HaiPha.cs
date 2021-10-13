using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI1
{
    class BTVN_BAI1_HaiPha : BTVN_BAI1_LoaiDien
    {
        public BTVN_BAI1_HaiPha() : base()
        {

        }
        public override double PhanTram(double soLuongDien, double donGia)
        {
            if (soLuongDien > 200)
            {
                return 0.98;
            }
            return 0;
        }
        public override string ToString()
        {
            return "hai pha";
        }
    }
}
