using System;
using System.Text;

namespace TH_BAI1
{
    class Program
    {
        static void TinhChuVi(double banKinh)
        {
            Console.WriteLine("Chu vi hình trong là: " + 2 * banKinh * Math.PI);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập bán kính hình tròn: ");
            double banKinh = double.Parse(Console.ReadLine());
            TinhChuVi(banKinh);
        }
    }
}
