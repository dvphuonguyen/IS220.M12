using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI1
{
    class BTVN_BAI1_CustomerManager
    {
        private int soLuong;
        private List<BTVN_BAI1_KhachHang> list;
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public List<BTVN_BAI1_KhachHang> List { get => list; set => list = value; }
        
        public BTVN_BAI1_CustomerManager()
        {
            soLuong = 0;
            list = new List<BTVN_BAI1_KhachHang>();
        }
        public BTVN_BAI1_CustomerManager(int size)
        {
            soLuong = size;
            list = new List<BTVN_BAI1_KhachHang>(soLuong);
        }
        //0: moi tao khong nam trong ds
        //1: co trong ds nhung ngay thoa
        //2: co trong ds nhung k thoa
        public int KiemTraNhap(string id, string name, DateTime date, BTVN_BAI1_LoaiDien loaiDien)
        {
            foreach(BTVN_BAI1_SanXuat khachHang in list)
            {
                if(string.Equals(id.ToLower(), khachHang.MaKH.ToLower()) && string.Equals(name.ToLower(), khachHang.TenKH.ToLower()))
                {
                    Console.WriteLine(date + "\t" + khachHang.NgayHD);
                    Console.WriteLine(loaiDien + "\t" + khachHang.LoaiDien);
                    if (DateTime.Compare(date, khachHang.NgayHD) != 0 && khachHang.LoaiDien.GetType() == loaiDien.GetType())
                    {
                        
                        return 1;
                    }
                    return 2;
                }
            }
            return 0;
        }
        public void Nhap()
        {
            string maKH, tenKH, ngay, thang, nam, date;
            DateTime ngayHD;
            double soLuongDien, donGia, dinhMuc;
            BTVN_BAI1_LoaiDien loaiDien;
            BTVN_BAI1_KhachHang khachHang;
            do
            {
                Console.WriteLine("----------Nhap khach hang moi----------");
                Console.Write("Nhap ma khach hang: ");
                maKH = Console.ReadLine();
                if (!string.IsNullOrEmpty(maKH))
                {
                    Console.Write("Nhap ten khach hang: ");
                    tenKH = Console.ReadLine();
                    Console.Write("Nhap ngay: ");
                    ngay = Console.ReadLine();
                    Console.Write("Nhap thang: ");
                    thang = Console.ReadLine();
                    Console.Write("Nhap nam: ");
                    nam = Console.ReadLine();
                    date = thang + "/" + ngay + "/" + nam;
                    ngayHD = Convert.ToDateTime(date);
                    Console.Write("Nhap so luong dien: ");
                    soLuongDien = double.Parse(Console.ReadLine());
                    Console.Write("Nhap don gia: ");
                    donGia = double.Parse(Console.ReadLine());
                    Console.Write("Chon kieu khach hang: \n\t0: Kinh doanh\n\t1:Sinh hoat\n\t2:San xuat\n");
                    Console.Write("Nhap su lua chon cua ban: ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            khachHang = new BTVN_BAI1_KinhDoanh(maKH, tenKH, ngayHD, soLuongDien, donGia);
                            list.Add(khachHang);
                            break;
                        case 1:
                            Console.Write("Nhap dinh muc: ");
                            dinhMuc = double.Parse(Console.ReadLine());
                            khachHang = new BTVN_BAI1_SinhHoat(maKH, tenKH, ngayHD, soLuongDien, donGia, dinhMuc);
                            list.Add(khachHang);
                            break;
                        case 2:
                            Console.Write("Chon loai dien: \n\t0: Hai pha\n\t1:Ba pha\n");
                            Console.Write("Nhap su lua chon cua ban: ");
                            int choice1 = int.Parse(Console.ReadLine());
                            if (choice1 == 0)
                            {
                                loaiDien = new BTVN_BAI1_HaiPha();
                            }
                            else
                            {
                                loaiDien = new BTVN_BAI1_BaPha();
                            }
                            if(KiemTraNhap(maKH, tenKH, ngayHD, loaiDien) < 2)
                            {
                                khachHang = new BTVN_BAI1_SanXuat(maKH, tenKH, ngayHD, soLuongDien, donGia, loaiDien);
                                list.Add(khachHang);
                            }
                            else
                            {
                                Console.WriteLine("Khach hang co cung ma, cung ten thi phai khac nhau ngay hoa don nhung giong nhau loai dien");
                            }
                            break;
                        default:
                            break;
                    }
                }
            } while (!string.IsNullOrEmpty(maKH));
        }

        public void Xuat(int thang, int nam)
        {
            int count = 0;
            Console.Write("Thong tin khach hang co hoa don vao thang {0} nam {1} la: ", thang, nam);
            foreach(BTVN_BAI1_KhachHang khachHang in list)
            {
                //Console.WriteLine(khachHang.NgayHD.Year);
                if(khachHang.NgayHD.Month == thang && khachHang.NgayHD.Year == nam)
                {
                    Console.WriteLine("\n"+khachHang);
                    count = 1;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("khong tim thay hoa don");
            }
        }
    }
}
