using System;

namespace DangVuPhuongUyen_19520345
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("----------Hình tròn:---------- ");
            Console.WriteLine("Nhập bán kính: ");
            double banKinh = double.Parse(Console.ReadLine());
            HinhTron circle = new HinhTron(banKinh);
            Console.WriteLine(circle);

            Console.WriteLine("----------Hình trụ:---------- ");
            Console.WriteLine("Nhập bán kính: ");
            double banKinh1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều cao: ");
            double chieuCao1 = double.Parse(Console.ReadLine());
            HinhTruTron cylinder  = new HinhTruTron(banKinh1, chieuCao1);
            Console.WriteLine(cylinder);

        }
    }
}
