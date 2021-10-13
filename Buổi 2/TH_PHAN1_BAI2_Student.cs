using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_BAI2
{
    class TH_PHAN1_BAI2_Student
    {
        private int maSV;
        private string hoTen;
        private float diemLT, diemTH;
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public float DiemLT { get; set; }
        public float DiemTH { get; set; }
        public TH_PHAN1_BAI2_Student()
        {
            maSV = 0;
            hoTen = null;
            diemLT = 0;
            diemTH = 0;
        }
        public TH_PHAN1_BAI2_Student(int id, string name, float lt, float th)
        {
            maSV = id;
            hoTen = name;
            diemLT = lt;
            diemTH = th;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma so sinh vien: ");
            maSV = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap diem ly thuyet sinh vien: ");
            diemLT = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem thuc hanh sinh vien: ");
            diemTH = float.Parse(Console.ReadLine());
        }
        public float DiemTB()
        {
            return (diemLT + diemTH) / 2;
        }
        public override string ToString()
        {
            return "Thong tin sinh vien: \n\tMa so sinh vien: " + maSV + ".\n\tHo ten: " + hoTen + ". \n\tDiem ly thuyet: " + diemLT + ". \n\tDiem thuc hanh: " + diemTH + ".\n\tDiem trung binh: " + DiemTB();
        }
    }
}
