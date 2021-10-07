using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListQuanLySV
{
    class ListSinhVien
    {
        private string tenSV;
        private float diemTB;
        public string TenSV { get => tenSV; set => tenSV = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }
        public ListSinhVien()
        {
            tenSV = "Nguyen Van A";
            diemTB = 10;
        }
        public ListSinhVien(string name, float point)
        {
            tenSV = name;
            diemTB = point;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten sinh vien: ");
            tenSV = Console.ReadLine();
            Console.Write("Nhap diem trung binh sinh vien: ");
            diemTB =float.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "\tTen sinh vien: " + tenSV + " \n\tDiem trung binh: " + diemTB + "\n";
        }

    }
}
