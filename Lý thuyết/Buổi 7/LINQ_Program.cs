using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LyThuyet
{
    class LINQ_Program
    {
        public static string GioiTinhSV(bool gentle){
            if (gentle == true){
                return "Nu";
            }
            return "Nam";
        }

        public static void InDanhSachSinhVien(List<LINQ_SinhVien> sinhVien)
        {
            foreach (var sVien in sinhVien)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", sVien.MaSV, sVien.TenSV, sVien.DiemTB, GioiTinhSV(sVien.GioiTinh));
            }
        }
        public static void InSVCoDiemTBLonHonHoacBang5(List<LINQ_SinhVien> sinhVien)
        {
            var array = sinhVien
                        .Where(d => d.DiemTB >= 5);
            foreach (var sVien in array)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", sVien.MaSV, sVien.TenSV, sVien.DiemTB, GioiTinhSV(sVien.GioiTinh));
            }
        }

        public static void TimSVCoTenNhapVao(List<LINQ_SinhVien> sinhVien)
        {
            Console.Write("Nhap ten sinh vien can tim: ");
            string x = Console.ReadLine();
            var array = sinhVien
                        .Where(d => d.TenSV.ToLower().Contains( x.ToLower()));
            foreach (var sVien in array)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", sVien.MaSV, sVien.TenSV, sVien.DiemTB, GioiTinhSV(sVien.GioiTinh));
            }
        }

        public static void SapXepSVTangTheoDTB(List<LINQ_SinhVien> sinhVien)
        {
            var array = sinhVien
                        .OrderBy(d => d.DiemTB);
            foreach (var sVien in array)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", sVien.MaSV, sVien.TenSV, sVien.DiemTB, GioiTinhSV(sVien.GioiTinh));
            }
        }
        public static void GomNhomVaSapXepSVTheoDTBTangDan(List<LINQ_SinhVien> sinhVien)
        {
            var array = sinhVien
                .GroupBy(d => d.GioiTinh)
                .Select(group => new
                {
                    Key = group.Key,
                    sinhvien = group.OrderBy(x => x.DiemTB)
                });
            foreach (var namegroup in array)
            {
                Console.WriteLine("----Gioi tinh: {0}", GioiTinhSV(namegroup.Key));
                foreach (var sVien in namegroup.sinhvien)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", sVien.MaSV, sVien.TenSV, sVien.DiemTB, GioiTinhSV(sVien.GioiTinh));
                }
            }

        }

        public static void GomNhomVaDTBMax(List<LINQ_SinhVien> sinhVien)
        {
            var array = sinhVien
                 .GroupBy(d => d.GioiTinh)
                 .Select(group => new
                 {
                     Key = group.Key,

                     sinhvien = group.Max(x => x.DiemTB)
                 });
            foreach (var sVien in array)
            {
                Console.WriteLine("Gioi tinh: {0}\tDiem trung binh: {1}", GioiTinhSV(sVien.Key), sVien.sinhvien);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Tao danh sach 5 sinh vien
            var sinhVien = new List<LINQ_SinhVien>
            {
                new LINQ_SinhVien{TenSV = "Dang Vu Phuong Uyen", MaSV ="19520345", DiemTB = 8.75, GioiTinh = true },
                new LINQ_SinhVien{TenSV = "Nguyen Thi Thu Phuong", MaSV ="19522066", DiemTB = 8, GioiTinh = true },
                new LINQ_SinhVien{TenSV = "Dinh Cong Thanh", MaSV ="19522221", DiemTB = 8.1, GioiTinh = false },
                new LINQ_SinhVien{TenSV = "Nguyen Ngoc Thien", MaSV ="19522264", DiemTB = 8.4, GioiTinh = false },
                new LINQ_SinhVien{TenSV = "Dang Phuc Toan", MaSV ="19522357", DiemTB = 8.2, GioiTinh = false},
            };

            //Su dungcu phap LINQ => In danh sach moi tao
            Console.WriteLine("--------------------Danh sach tat ca sinh vien: --------------------");
            InDanhSachSinhVien(sinhVien);
            
            //Su dungcu phap LINQ => Liet ke sinh vien co diemtb>=5
            Console.WriteLine("--------------------Danh sach sinh vien co diem trung binh >=5 : --------------------");
            InSVCoDiemTBLonHonHoacBang5(sinhVien);

            //Su dungcu phap LINQ => Tim sinh vien co ten X (X nhap)
            Console.WriteLine("--------------------Tim sinh vien co ten theo ten vua nhap: --------------------");
            TimSVCoTenNhapVao(sinhVien);

            //Su dungcu phap LINQ => Sap xep danh sach sinh vien tang theo diemtb
            Console.WriteLine("--------------------Danh sach sinh vien duoc sap xep theo diem trung binh tang dan: --------------------");
            SapXepSVTangTheoDTB(sinhVien);

            //Su dungcu phap LINQ => Gom nhom sinh vien theo gioi tinh va sap xep heo diem trung binh cua sinh vien
            Console.WriteLine("--------------------Gom nhom theo gioi tinh vaf sap xep sinh vien theo diem trung binh tang dan: --------------------");
            GomNhomVaSapXepSVTheoDTBTangDan(sinhVien);

            //Su dungcu phap LINQ =>Cho biet diem trung binh cao nhat trong tung gioi tinh
            Console.WriteLine("--------------------Diem trung binh cao nhat trong tung gioi tinh: --------------------");
            GomNhomVaDTBMax(sinhVien);
        }
    }
}
