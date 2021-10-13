using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_BAI2
{
    class TH_PHAN1_BAI2_StudentManager
    {
        private List<TH_PHAN1_BAI2_Student> list = new List<TH_PHAN1_BAI2_Student>();
        private int soLuong;
        public int SoLuong { get; set; }
        public List<TH_PHAN1_BAI2_Student> List { get; set; }
        public TH_PHAN1_BAI2_StudentManager()
        {
            soLuong = 0;
        }
        public TH_PHAN1_BAI2_StudentManager(int size)
        {
            soLuong = size;
            list = new List<TH_PHAN1_BAI2_Student>(soLuong);
        }
        public void Nhap(TH_PHAN1_BAI2_Student sinhVien)
        {
            list.Add(sinhVien);
        }
        public void Xuat()
        {
            foreach(TH_PHAN1_BAI2_Student sinhVien in list)
            {
                Console.WriteLine($"{sinhVien}");
            }
        }
    }
}
