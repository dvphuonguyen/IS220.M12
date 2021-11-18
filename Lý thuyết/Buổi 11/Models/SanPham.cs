using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DangVuPhuongUyen_19520345.Models
{
    public class SanPham
    {
        private string maSP;
        private string tenSP;
        private string dVT;
        private string nuocSX;
        private int gia;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        public string DVT
        {
            get { return dVT; }
            set { dVT = value; }
        }
        public string NuocSX
        {
            get { return nuocSX; }
            set { nuocSX = value; }
        }
        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public SanPham()
        {

        }
        public SanPham(string masp, string tensp, string dvt, string nuocsx, int gi)
        {
            maSP = masp;
            tenSP = tensp;
            dVT = dvt;
            nuocSX = nuocsx;
            gia = gi;
        }
    }
}
