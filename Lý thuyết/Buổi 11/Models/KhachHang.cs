using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DangVuPhuongUyen_19520345.Models
{
    public class KhachHang
    {
        private string maKH;
        private string hoTen;
        private string dChi;
        private string soDT;
        private DateTime ngSinh;
        private DateTime ngDK;
        private int doanhSo;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string DChi
        {
            get { return dChi; }
            set { dChi = value; } 
        }
             public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        public DateTime NgSinh
        {
            get { return ngSinh; }
            set { ngSinh = value; }
        }
        public DateTime NgDK
        {
            get { return ngDK; }
            set { ngDK = value; }
        }
        public int DoanhSo
        {
            get { return doanhSo; }
            set { doanhSo = value; }
        }
        public KhachHang()
        {

        }
        public KhachHang(string makh, string hoten, string dchi, string sodt,  DateTime ngsinh, DateTime ngdk, int doanhso)
        {
            MaKH = makh;
            hoTen = hoten;
            dChi = dchi;
            soDT = sodt;
            ngSinh = ngsinh;
            ngDK = ngdk;
            doanhSo = doanhso;
        }
   
    }
}
