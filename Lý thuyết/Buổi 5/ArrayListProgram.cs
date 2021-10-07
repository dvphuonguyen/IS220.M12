using System;
using System.Collections;

namespace ArrayListArray
{
    class ArrayListProgram
    {
        public static void NhapMang(ArrayList list)
        {
            Console.WriteLine("Nhap so luong phan tu mang: ");
            int soLuong = int.Parse(Console.ReadLine());
            for(int  i = 0; i < soLuong; i++)
            {
                Console.Write("Nhap gia tri phan tu thu {0}: ", i);
                list.Add(int.Parse(Console.ReadLine()));
            }
        }
        public static void XuatMang(ArrayList list)
        {
            Console.Write("Cac phan tu trong mang: ");
            foreach(object item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        public static string TimXTrongMang(ArrayList list, int x)
        {
            if (list.Contains(x))
            {
                return "Tim thay " + x;
            }
            return "Khong tim thay " + x;
        }
        public static void XoaX(ArrayList list)
        {
            Console.WriteLine("Nhap gia tri can xoa: ");
            int x = int.Parse(Console.ReadLine());
            while (list.Contains(x))
            {
                list.Remove(x);
            }
        }
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("------------Nhap mang------------");
            NhapMang(list);
            Console.WriteLine("------------Xuat mang------------");
            XuatMang(list);
            Console.WriteLine("------------Tim x trong mang------------");
            Console.WriteLine("Nhap gia tri can tim: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(TimXTrongMang(list, x));
            Console.WriteLine("------------Sap xep mang tang dan------------");
            list.Sort();
            XuatMang(list);
            Console.WriteLine("------------Xoa x trong mang------------");
            XoaX(list);
            XuatMang(list);
        }
    }
}
