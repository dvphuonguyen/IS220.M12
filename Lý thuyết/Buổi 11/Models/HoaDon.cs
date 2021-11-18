using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DangVuPhuongUyen_19520345.Models
{
    public class HoaDon
    {
        private string soHD;
        private string ngayHD;
        private string maKH;
        private string maNV;
        private int triGia;
        public string SoHD
        {
            get { return soHD; }
            set { soHD = value; }
        }
        public string NgayHD
        {
            get { return ngayHD; }
            set { ngayHD = value; }
        }
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public int Trigia
        {
            get { return triGia; }
            set { triGia = value; }
        }
        public HoaDon()
        {

        }

        public HoaDon(string sohd, string ngayhd, string makh, string manv, int trigia)
        {
            soHD = sohd;
            ngayHD = ngayhd;
            maKH = makh;
            maNV = manv;
            triGia = trigia;
        }
    }
}
