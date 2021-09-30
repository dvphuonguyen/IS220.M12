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
    }
}
