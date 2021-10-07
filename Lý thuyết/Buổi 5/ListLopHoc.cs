using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListQuanLySV
{
    class ListLopHoc
    {
        private List<ListSinhVien> lopHoc { get; set; }
        private int soLuong;
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public List<ListSinhVien> LopHoc { get => lopHoc; set => lopHoc = value; }
        public ListLopHoc()
        {
            soLuong = 0;
            lopHoc = new List<ListSinhVien>();
        }
        public ListLopHoc(int size)
        {
            soLuong = size;
            lopHoc = new List<ListSinhVien>();
        }
        public void NhapLopHoc()
        {
            Console.Write("Nhap so luong sinh vien: ");
            soLuong = int.Parse(Console.ReadLine());
            for(int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu {0}: ", i);
                ListSinhVien sinhVien = new ListSinhVien();
                sinhVien.Nhap();
                lopHoc.Add(sinhVien);
            }
        }
        public void XuatLopHoc()
        {
            Console.WriteLine("Danh sach lop hoc: ");
            for(int  i = 0; i < soLuong; i++)
            {
                Console.WriteLine(lopHoc[i]);
            }
        }
        public bool TimSVTheoten()
        {
            Console.WriteLine("Nhap ten sinh vien can tim: ");
            string name = Console.ReadLine();
            foreach(ListSinhVien sinhVien in lopHoc)
            {
                if (sinhVien.TenSV.ToLower().Contains(name.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        public void XoaSVTheoten()
        {
            Console.WriteLine("Nhap ten sinh vien can xoa: ");
            string name = Console.ReadLine();
            for (int i = 0; i < soLuong; i++)
            {
                if (lopHoc[i].TenSV.ToLower().Equals(name.ToLower()))
                {
                    lopHoc.RemoveAt(i);
                }
            }
        }
        public void SapXep()
        {
            lopHoc.Sort(delegate (ListSinhVien sv1, ListSinhVien sv2) {
                return sv1.DiemTB.CompareTo(sv2.DiemTB);
            });
        }
    }
}
