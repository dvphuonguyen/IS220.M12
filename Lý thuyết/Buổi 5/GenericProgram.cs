using System;

namespace Generic_QuanLyMangMotChieu
{
    class GenericProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var arrayInt = new GenericArray<int>();
            arrayInt.NhapMang();
            arrayInt.XuatMang();
            Console.WriteLine("Tong cac phan tu trong mang: {0}", arrayInt.TongMang());
            Console.WriteLine("Gia tri lon nhat trong mang: {0}", arrayInt.MaxArray());
            Console.Write("Nhap gia tri can tim: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Vi tri dau tien cua {0} trong mang la: {1}", x, arrayInt.TimX(x));

            var arrayFloat = new GenericArray<float>();
            arrayFloat.NhapMang();
            arrayFloat.XuatMang();
            Console.WriteLine("Tong cac phan tu trong mang: {0}", arrayFloat.TongMang());
            Console.WriteLine("Gia tri lon nhat trong mang: {0}", arrayFloat.MaxArray());
            Console.Write("Nhap gia tri can tim: ");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Vi tri dau tien cua {0} trong mang la: {1}", x, arrayFloat.TimX(x1));
        }
    }
}
