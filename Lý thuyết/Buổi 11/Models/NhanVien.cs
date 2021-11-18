using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DangVuPhuongUyen_19520345.Models
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private string soDT;
        private DateTime ngVL;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        public DateTime NgVL
        {
            get { return ngVL; }
            set { ngVL = value; }
        }
        public NhanVien()
        {

        }
        public NhanVien(string manv, string hoten, string sodt, DateTime ngvl)
        {
            maNV = manv;
            hoTen = hoten;
            soDT = sodt;
            ngVL = ngvl;
        }

    }
}
