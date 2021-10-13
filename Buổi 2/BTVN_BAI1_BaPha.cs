using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI1
{
    class BTVN_BAI1_BaPha : BTVN_BAI1_LoaiDien
    {
        public BTVN_BAI1_BaPha() : base()
        {

        }
        public override double PhanTram(double soLuongDien, double donGia)
        {
            if (soLuongDien > 150)
            {
                return 0.97;
            }
            return 0;
        }
        public override string ToString()
        {
            return "ba pha";
        }
    }
}
