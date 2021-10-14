using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_THEM
{
    class TH_THEM_Date
    {
        private int day, month, year;
        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public TH_THEM_Date()
        {
            day = month = year = 0;
        }
        public TH_THEM_Date(int ngay, int thang, int nam)
        {
            day = ngay;
            month = thang;
            year = nam;
        }

        public bool NamNhuan(int year)
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                return true;
            return false;
        }
        public int SoNgay(int thang, int nam)
        {
            switch (thang)
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
        public int TongNgay()
        {
            int tong = 0;
            for (int i = 1; i < month; i++)
            {
                tong += SoNgay(i, year);
            }
            return tong;
        }

        public static TH_THEM_Date operator ++(TH_THEM_Date date1)
        {

            if (date1.Day + 1 <= date1.SoNgay(date1.Month, date1.Year))
            {
                return new TH_THEM_Date(date1.Day + 1, date1.Month, date1.Year);
            }
            else
            {
                if(date1.Month + 1 == 13)
                {
                    return new TH_THEM_Date(1, 1, date1.Year + 1);
                }
                else
                {
                    return new TH_THEM_Date(1, date1.Month + 1, date1.year);
                }
            }
        }
        public static bool operator ==(TH_THEM_Date date1, TH_THEM_Date date2)
        {
            if (date2.year == date1.Year && date2.month == date1.Month && date2.year == date1.Year)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(TH_THEM_Date date1, TH_THEM_Date date2)
        {
            if (date2.year == date1.Year && date2.month == date1.Month && date2.year == date1.Year)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", day, month, year);
        }
    }
}
