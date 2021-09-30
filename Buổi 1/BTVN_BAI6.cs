using System;

namespace BTVN_BAI6
{
    class Program_Date
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập thông tin ngày: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập thông tin tháng: ");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập thông tin năm: ");
            int nam = int.Parse(Console.ReadLine());
            Date date = new Date(ngay, thang, nam);
            Console.WriteLine( "\t==>Ngày {0}/{1}/{2} là {3} ", ngay, thang, nam, date.NgayTrongTuan());
        }
        /*
        static int[] month_table = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static int[] leap_month_table = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static string[] day = { "Thu tu", "Thu nam", "Thu sau", "Thu 7", "Chu nhat", "Thu hai", "Thu ba" };

        public static bool isLeapYear(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) ||
                    (year % 400 == 0));
        }

        public static void GetDayOfWeek(int d, int m, int y)
        {
            int TongNgay = 0;
            for (int i = 1970; i < y; i++)
            {
                if (isLeapYear(i))
                    TongNgay += 366;
                else
                    TongNgay += 365;
            }
            Console.Write(TongNgay);
            for (int i = 1; i < m; i++)
                if (isLeapYear(y))
                    TongNgay += leap_month_table[i];
                else
                    TongNgay += month_table[i];
            TongNgay += d;
            Console.Write(TongNgay);
            Console.Write(day[TongNgay % 7]);

        }
        static void Main(string[] args)
        {
            Console.Write("Nhap Ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            GetDayOfWeek(ngay, thang, nam);
        }
        */
    }
}
