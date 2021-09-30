using System;

namespace TH_BAI3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            NhanVien employee = new NhanVien();
            Console.WriteLine("Nhập thông tin nhân viên: ");
            employee.Nhap();
            Console.WriteLine(employee.KiemTraNghiHuu());
        }
    }
}
