using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI6
{
    class Date
    {
        private int ngay;
        public int Ngay
        {
            get { return ngay; }
            set { ngay = Ngay; }
        }
        private int thang;
        public int Thang
        {
            get { return thang; }
            set { thang = Thang; }
        }
        private int nam;
        public int Nam
        {
            get { return nam; }
            set { nam = Nam; }
        }

        public Date()
        {
            ngay = 1;
            thang = 1;
            nam = 2021;
        }
        public Date(int day, int month, int year)
        {
            ngay = day;
            thang = month;
            nam = year;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", ngay, thang, nam);
        }

        public bool NamNhuan(int year)
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                return true;
            return false;
        }
        public int SoNgay(int month)
        {
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                    break;
                case 2:
                    if (NamNhuan(nam) == true)
                        return 29;
                    else
                        return 28;
                    break;
                default: 
                    return 31;
                    break;
            }
        }

        public int TongNgay(){
            int tong = ngay;
            for(int i = 1970; i < nam; i++){
                if(NamNhuan(i) == true) 
                    tong += 366;
                else
                    tong += 365;
            }
            for(int i = 1; i < thang ; i++){
                tong += SoNgay(i);
            }
            return tong;
        }
        
        public string NgayTrongTuan()
        {
            int n = TongNgay() % 7;
            switch (n)
            {
                case 1:
                    return "Thứ 5";
                    break;
                case 2:
                    return "Thứ 6";
                    break;
                case 3:
                    return "Thứ 7";
                    break;
                case 4:
                    return "Chủ nhật";
                    break;
                case 5:
                    return "Thứ 2";
                    break;
                case 6:
                    return "Thứ 3";
                    break;
                default:
                    return "Thứ 4";
                    break;
            }
        }
    }
}
