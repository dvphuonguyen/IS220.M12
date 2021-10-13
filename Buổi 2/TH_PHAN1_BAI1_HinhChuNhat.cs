using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_BAI1
{
    class TH_PHAN1_BAI1_HinhChuNhat
    {
        private float chieuDai, chieuRong;
        public float ChieuDai { get; set; }
        public float ChieuRong { get; set; }
        public TH_PHAN1_BAI1_HinhChuNhat()
        {
            chieuDai = 5;
            chieuRong = 4;
        }
        public TH_PHAN1_BAI1_HinhChuNhat(int d, int r)
        {
            chieuDai = d;
            chieuRong = r;
        }
        public float ChuVi()
        {
            return 2 * (chieuDai + chieuRong);
        }
        public float DienTich()
        {
            return chieuDai * chieuRong;
        }
        public override string ToString()
        {
            return "Chieu dai: " + chieuDai + ".\tChieu rong: " + chieuRong + ".\tChu vi: " + ChuVi() + ".\tDien tich: " + DienTich();
        }
    }
}
