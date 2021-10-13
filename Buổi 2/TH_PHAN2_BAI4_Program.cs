using System;
using System.Collections.Generic;

namespace TH_PHAN2_BAI4
{
    class TH_PHAN2_BAI4_Program
    {
        static void Nhap(Dictionary<string, string> dict, int soLuong)
        {
            string key, value;
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write("Nhap so dien thoai luu tru: ");
                key = Console.ReadLine();
                Console.Write("Nhap dia chi dang ky: ");
                value = Console.ReadLine();
                dict.Add(key, value);
            }
        }
        static void TraCuuTheoSdt(Dictionary<string, string> dict, int soLuong)
        {
            Console.Write("Nhap so dien thoai can tra cuu: ");
            string sdt = Console.ReadLine();
            if (dict.ContainsKey(sdt))
            {
                Console.Write("Thong tin dia chi dang ky cua so dien thoai {0} la: ", sdt);
                foreach (KeyValuePair<string, string> item in dict)
                {
                    if(item.Key == sdt)
                    {
                        Console.Write(item.Value + ",\t");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Khong tim thay so dien thoai {0}", sdt);
            }
            
        }
        static void TraCuuTheoDc(Dictionary<string, string> dict, int soLuong)
        {
            Console.Write("Nhap dia chi dang ky can tra cuu: ");
            string diaChi = Console.ReadLine();
            if (dict.ContainsValue(diaChi))
            {
                Console.Write("Cac so dien thoai dang ky o dia chi {0} la: ", diaChi);
                foreach (KeyValuePair<string, string> item in dict)
                {
                    if (item.Value == diaChi)
                    {
                        Console.Write(item.Key + ",\t");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Khong tim thay dia chi {0}", diaChi);
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong so dien thoai luu tru: ");
            int soLuong = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>(soLuong);
            Nhap(dict, soLuong);
            TraCuuTheoSdt(dict, soLuong);
            TraCuuTheoDc(dict, soLuong);
        }
    }
}
