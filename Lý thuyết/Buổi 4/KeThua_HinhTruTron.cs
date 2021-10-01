using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangVuPhuongUyen_19520345
{
    internal class HinhTruTron : HinhTron
    {
        private double chieuCao;
        public double ChieuCao
        {
            get => chieuCao;
            set
            {
                if(value > 0)
                {
                    chieuCao = value;
                }
            }
        }
        public HinhTruTron()
        {
            chieuCao = 0;
        }
        public HinhTruTron( double h)
        {
            chieuCao = h;
        }
        public HinhTruTron(double r, double h) : base(r)
        {
            chieuCao = h;
        }
        public double DienTichToanPhan()
        {
            return 2 * base.DienTich() + base.ChuVi() * chieuCao;
        }
        public double TheTich()
        {
            return base.DienTich() * chieuCao;
        }
        public override string ToString()
        {
            return string.Format("\t Ban kinh: {0}\n\t Chieu cao: {1}\n\t Dien tich toan phan: {2} \n\t The tich: {3}", base.BanKinh, chieuCao, DienTichToanPhan(), TheTich());
        }

    }
}
