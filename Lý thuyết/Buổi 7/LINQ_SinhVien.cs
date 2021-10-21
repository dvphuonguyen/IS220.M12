using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyThuyet
{
    class LINQ_SinhVien
    {
        private string tenSV, maSV;
        private double diemTB;
        private bool gioiTinh;
        //true: Nu false: Nam

        public string TenSV { get => tenSV; set => tenSV = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public LINQ_SinhVien()
        {
            tenSV = maSV = null;
            diemTB = 0;
            gioiTinh = true;
        }

        public LINQ_SinhVien(string name, string id, double point, bool gentle)
        {
            tenSV = name;
            maSV = id;
            diemTB = point;
            gioiTinh = gentle;
        }

    }
}
