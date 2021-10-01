using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangVuPhuongUyen_19520345
{
    internal class HinhTron
    {
        private double banKinh;
        public double BanKinh
        {
            get => banKinh;
            set {
                if (value > 0)
                    banKinh = value;
            }
        }
        public HinhTron()
        {
            banKinh = 0;
        }
        public HinhTron(double a)
        {
            banKinh = a;
        }
        public double ChuVi()
        {
            return Math.PI * banKinh * 2;
        }
         public double DienTich()
        {
            return Math.PI * banKinh * banKinh;
        }

        public override string ToString()
        {
            return string.Format("\t BanKinh: {0}\n\t Chu vi: {1}\n\t Dien tich : {2}", banKinh, ChuVi(), DienTich());
        }
    }
}
