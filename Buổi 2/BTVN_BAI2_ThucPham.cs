using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_BAI2
{
    class ThucPham : HangHoa
    {
        private string nhaCungCap;
        private DateTime ngaySanXuat, ngayHetHan;
        public string NhaCungCap { get => nhaCungCap; set => nhaCungCap = value; }
        public DateTime NgaySanXuat { get => ngaySanXuat; set => ngaySanXuat = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }

        public ThucPham() : base()
        {
            nhaCungCap = null;
            ngaySanXuat = DateTime.Now;
            ngayHetHan = DateTime.Now.AddDays(10);
        }
        public ThucPham(string id, string name, int num, double price, string name2, DateTime date1, DateTime date2) : base(id, name, num, price)
        {
            nhaCungCap = name2;
            ngaySanXuat = date1;
            ngayHetHan = date2;
        }
        public override string ToString()
        {
            return base.ToString();
            return string.Format("\tNha cung cap: {0}\n\tNgay san xuat: {1}\n\tNgay het han: {2}\ntThanh tien: {3}\n", nhaCungCap, ngaySanXuat, ngayHetHan, ThanhTien());
        }
        public override double ThanhTien()
        {
            return base.ThanhTien() * 1.05;
        }
        public override bool Nhaphang()
        {
            if (NgayHetHan < DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
