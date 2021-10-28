using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork
{
    class Program
    {
        public static  void ThemSinhVien(string id, string name, double grade)
        {
            using (var context = new SinhVienContext())
            {
                Console.WriteLine("Da luu");
                context.Sinhvien.Add(new Sinhvien()
                {
                    masv=id, tendv = name, diemtb=grade
                });

                // Thực hiện Insert vào DB các dữ liệu đã thêm.
                int rows = context.SaveChanges();
                Console.WriteLine($"Da luu {rows}  sinh vien");
                
            }
        }
        public static void InDanhSachMoiTao()
        {
            using (var context = new SinhVienContext())
            {
                 var sinhVien = context.SinhVien.ToList();
                 Console.WriteLine("Tat ca sinh vien");
                 foreach (var sVien in SinhVien)
                 {
                     Console.WriteLine("Ma sinh vien: {0}\tTen sinh vien: {1}\tDiem trung binh: {2}", sVien.masv, sVien.tensv, sVien.diemtb);
                 }
                 Console.WriteLine();
                 Console.WriteLine();
            }
        }
        public static void InSVCoDiemTBLonHonHoacBang5()
        {
            using (var context = new SinhVienContext())
            {
                var sinhVien = Context.SinhVien;
                var array = sinhVien
                            .Where(d => d.DiemTB >= 5);
                foreach (var sVien in array)
                {
                    Console.WriteLine("Ma sinh vien: {0}\tTen sinh vien: {1}\tDiem trung binh: {2}", sVien.masv, sVien.tensv, sVien.diemtb);
                }
            }
        }

        public static void TimSVCoTenNhapVao()
        {
            Console.Write("Nhap ten sinh vien can tim: ");
            string x = Console.ReadLine();

            using (var context = new SinhVienContext())
            {
                var sinhVien = Context.SinhVien;
                var array = sinhVien
                            .Where(d => d.tensv.ToLower().Contains( x.ToLower()));
                foreach (var sVien in array)
                {
                Console.WriteLine("Ma sinh vien: {0}\tTen sinh vien: {1}\tDiem trung binh: {2}", sVien.masv, sVien.tensv, sVien.diemtb);
                }
            }
        }

        public static void SapXepSVTangTheoDTB()
        {
            using (var context = new SinhVienContext())
            {
                var sinhVien = Context.SinhVien;
                var array = sinhVien
                            .OrderBy(d => d.diemtb);
                foreach (var sVien in array)
                {
                    Console.WriteLine("Ma sinh vien: {0}\tTen sinh vien: {1}\tDiem trung binh: {2}", sVien.masv, sVien.tensv, sVien.diemtb);
                }
            }
        }

        public static void GomNhomVaSapXepSVTheoDTBTangDan()
        {
            using (var context = new SinhVienContext())
            {
                var sinhVien = Context.SinhVien;
                var array = sinhVien
                    .GroupBy(d => d.tensv)
                    .Select(group => new
                    {
                        Key = group.Key,
                        sinhvien = group.OrderBy(x => x.diemtb)
                    });
                foreach (var namegroup in array)
                {
                    Console.WriteLine("----Ten sinh vien: {0}", namegroup.Key);
                    foreach (var sVien in namegroup.sinhvien)
                    {
                        Console.WriteLine("Ma sinh vien: {0}\tTen sinh vien: {1}\tDiem trung binh: {2}", sVien.masv, sVien.tensv, sVien.diemtb);
                    }
                }
            }
        }

        // Xóa sản phẩm có ProductID = id
        public static  void XoaSVDuaVaoMaSV()
        {
            Console.Write("Nhap ma sinh vien can xoa: ");
            string id  = Console.ReadLine();

            using (var context = new SinhVienContext())
            {
                var sinhVien =  (from s in context.SinhVien
                                     where (s.masv == id)
                                     select s
                                 )
                                .FirstOrDefault(); 

                if (sinhVien != null)
                {
                    context.Remove(sinhVien);
                    Console.WriteLine($"Xóa {sinhVien.masv}");
                    context.SaveChanges();
                }
            }
        }
        static void Main(string[] args)
        {
            ThemSinhVien('6', 'Nga', 8.6);
            InDanhSachMoiTao();
            InSVCoDiemTBLonHonHoacBang5();
            TimSVCoTenNhapVao();
            SapXepSVTangTheoDTB();
            GomNhomVaSapXepSVTheoDTBTangDan();
            XoaSVDuaVaoMaSV();
        }
    }
}
