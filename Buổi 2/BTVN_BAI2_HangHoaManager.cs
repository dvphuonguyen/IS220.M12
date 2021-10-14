using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI2
{
    class HangHoaManager
    {
        private int soLuong;
        private List<HangHoa> list;
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public List<HangHoa> List { get => list; set => list = value; }

        public HangHoaManager()
        {
            soLuong = 0;
            list = new List<HangHoa>();
        }

        public HangHoaManager(int size)
        {
            soLuong = size;
            list = new List<HangHoa>();
        }
        public bool KiemTraTrung(string id)
        {
            foreach(HangHoa hangHoa in list)
            {
                if (hangHoa.MaHH.Contains(id))
                {
                    return true;
                }
            }
            return false;
        }
        public void Nhap()
        {
            string maHH, tenHH, thuongHieu, loaiMay, nhaSanXuat, loaiGiaDung, nhaCungCap;
            DateTime ngaySanXuat, ngayHetHan, ngayNhap;
            int soLuongTK, thoiGianBaoHanh, choice ;
            double donGia;
            do
            {
                Console.Write("Nhap ma hang hoa: ");
                maHH = Console.ReadLine();
                if(!string.IsNullOrEmpty(maHH) && !KiemTraTrung(maHH))
                {
                    Console.Write("Nhap ten hang hoa: ");
                    tenHH = Console.ReadLine();
                    Console.Write("Nhap so luong ton kho: ");
                    soLuongTK = int.Parse(Console.ReadLine());
                    Console.Write("Nhap don gia: ");
                    donGia= double.Parse(Console.ReadLine());
                    Console.WriteLine("Menu:\n\t0:Dien may\n\t1: Thuc pham\n\t2: Gia dung");
                    Console.Write("Nhap su lau chon cua ban: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Console.Write("Nhap thuong hieu: ");
                            thuongHieu = Console.ReadLine();
                            Console.Write("Nhap loai may: ");
                            loaiMay = Console.ReadLine();
                            Console.Write("Nhap thoi gian bao hanh: ");
                            thoiGianBaoHanh = int.Parse(Console.ReadLine());
                            list.Add(new DienMay(maHH, tenHH, soLuongTK, donGia, thuongHieu, loaiMay, thoiGianBaoHanh));
                            break;
                        case 1:
                            Console.Write("Nhap nha cung cap: ");
                            nhaCungCap = Console.ReadLine();
                            do
                            {
                                Console.Write("Nhap ngay san xuat: ");
                                string ngay = Console.ReadLine();
                                Console.Write("Nhap thang san xuat: ");
                                string thang = Console.ReadLine();
                                Console.Write("Nhap nam san xuat: ");
                                string nam = Console.ReadLine();
                                string date = thang + "/" + ngay + "/" + nam;
                                ngaySanXuat = Convert.ToDateTime(date);
                                Console.Write("Nhap ngay het han: ");
                                string ngay1 = Console.ReadLine();
                                Console.Write("Nhap thang het han: ");
                                string thang1 = Console.ReadLine();
                                Console.Write("Nhap nam het han: ");
                                string nam1 = Console.ReadLine();
                                string date1 = thang1 + "/" + ngay1 + "/" + nam1;
                                ngayHetHan = Convert.ToDateTime(date1);
                                if (DateTime.Compare(ngayHetHan, ngaySanXuat) < 0)
                                {
                                    Console.WriteLine("Ngay het han phai lon hon ngay san xuat");
                                }
                            } while (DateTime.Compare(ngayHetHan, ngaySanXuat) < 0);
                            break;
                            list.Add(new ThucPham(maHH, tenHH, soLuongTK, donGia, nhaCungCap, ngaySanXuat, ngayHetHan));
                        case 2:
                            Console.Write("Nhapnha san xuat: ");
                            nhaSanXuat = Console.ReadLine();
                            Console.Write("Nhap loai gia dung: ");
                            loaiGiaDung = Console.ReadLine();
                            Console.Write("Nhap ngay nhap kho: ");
                            string ngay2 = Console.ReadLine();
                            Console.Write("Nhap thang nhap kho: ");
                            string thang2 = Console.ReadLine();
                            Console.Write("Nhap nam nhap kho: ");
                            string nam2 = Console.ReadLine();
                            string date2 = thang2 + "/" + ngay2 + "/" + nam2;
                            ngayNhap = Convert.ToDateTime(date2);
                            list.Add(new GiaDung(maHH, tenHH, soLuongTK, donGia, nhaSanXuat, loaiGiaDung, ngayNhap));
                            break;
                        default:
                            break;
                    }
                }
            } while(!string.IsNullOrEmpty(maHH));
        }
        public void XuatNhapHang()
        {
            Console.WriteLine("--------Cac hang hoa can nhap hang: --------");
            foreach(HangHoa hangHoa in list)
            {
                if(hangHoa.Nhaphang()== true)
                {
                    Console.WriteLine(hangHoa);
                }
            }
        }
    }
}
