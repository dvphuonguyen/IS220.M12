using System;
using System.Collections.Generic;

namespace ListQuanLySV
{
    class ListProgram
    {
        static void Main(string[] args)
        {
            ListLopHoc lop = new ListLopHoc();
            Console.WriteLine("-----Nhap danh sach sinh vien-----");
            lop.NhapLopHoc();
            Console.WriteLine("-----Xuat danh sach sinh vien-----");
            lop.XuatLopHoc();
            Console.WriteLine("-----Tim sinh vien theo ten-----");
            if (lop.TimSVTheoten() == true)
            {
                Console.WriteLine("Tim thay");
            }
            else
            {
                Console.WriteLine("Tim khong thay");
            }
            Console.WriteLine("-----Sap xep danh sach sinh vien-----");
            lop.SapXep();
            lop.XuatLopHoc();
            Console.WriteLine("-----Xoa sinh vien theo ten-----");
            Console.WriteLine();lop.XoaSVTheoten();
            lop.XuatLopHoc();
        }
    }
}
