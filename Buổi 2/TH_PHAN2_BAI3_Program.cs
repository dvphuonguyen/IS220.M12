using System;

namespace TH_PHAN2_BAI3
{
    class TH_PHAN2_BAI3_Program
    {
        static void Main(string[] args)
        {
            var arrayInt = new TH_PHAN2_BAI3_GenericArray<int>();
            arrayInt.NhapMang();
            arrayInt.XuatMang();
            Console.WriteLine("Gia tri lon nhat trong mang: {0}", arrayInt.MaxArray());
            Console.WriteLine("Gia tri nho nhat trong mang: {0}", arrayInt.MinArray());
        }
    }
}
