using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDTH_BAI1
{
    class HDTH_BAI1_TaiKhoan
    {
        private long soTK;
        private string tenTK;
        private double soTien;
        public long SoTK
        {
            get => soTK;
            set
            {
                soTK = value;
            }
        }
        public string TenTK
        {
            get => tenTK;
            set
            {
                tenTK = value;
            }
        }
        public double SoTien
        {
            get => soTien;
            set
            {
                soTien = value;
            }
        }
        public HDTH_BAI1_TaiKhoan()
        {
            soTK = 0;
            tenTK = null;
            soTien = 0;
        }
        public HDTH_BAI1_TaiKhoan(long tk, string ten, double tien)
        {
            soTK = tk;
            tenTK = ten;
            soTien = tien;
        }
        

        public override string ToString()
        {
            return string.Format("So tai khoan: {0},Tên: {1}, So tien: {2} USD", soTK, tenTK, soTien);
        }

        public bool NapTien(double tienNap)
        {
            if (tienNap >= 0)
            {
                soTien += tienNap;
                return true;
            }
            return false;

        }

        public bool RutTien()
        {
            Console.Write("Nhap so tien can rut:");
            double tienRut = double.Parse(Console.ReadLine());
            if (tienRut > 0 && (soTien - tienRut - tienRut * 0.01) >= 0)
            {
                soTien = soTien - (1.01 * tienRut);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
