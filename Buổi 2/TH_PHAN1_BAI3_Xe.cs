using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_BAI3
{
    class TH_PHAN1_BAI3_Xe
    {
        private string tenChuXe, loaiXe;
        private double triGiaXe, dungTichXyLanh;
        public string TenChuXe { get => tenChuXe; set => tenChuXe = value; }
        public string LoaiXe { get => loaiXe; set => loaiXe = value; }
        public double TriGiaXe { get => triGiaXe; set => triGiaXe = value; }
        public double DungTichXyLanh { get => dungTichXyLanh; set => dungTichXyLanh = value; }
        public TH_PHAN1_BAI3_Xe()
        {
            tenChuXe = loaiXe = null;
            triGiaXe = dungTichXyLanh = 0;
        }
        public TH_PHAN1_BAI3_Xe(string name, string type, double price, double xyLanh)
        {
            tenChuXe = name;
            loaiXe = type;
            triGiaXe = price;
            dungTichXyLanh = xyLanh;
        }
        public double ThueDong()
        {
            if(dungTichXyLanh < 100)
            {
                return triGiaXe * 0.01;
            }
            else if(dungTichXyLanh <= 175)
            {
                return triGiaXe * 0.03;
            }
            else
            {
                return triGiaXe * 0.05;
            }
        }
        public override string ToString()
        {
            return "Thong tin xe: \n\tTen chu xe: " + tenChuXe + ". \n\tLoai xe: " + loaiXe + ".\n\tTri gia xe: " + triGiaXe + ".\n\tDung tich xy lanh: " + dungTichXyLanh + ".\n\tThue phai dong: " + ThueDong() + ".";
        }
    }
}
