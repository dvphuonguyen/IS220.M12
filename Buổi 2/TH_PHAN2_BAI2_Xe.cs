using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_PHAN2_BAI1
{
    class TH_PHAN2_BAI2_Xe
    {
        private string maSoChuyen, hoTenTaiXe, soXe;
        private double khoiLuongHangHoa, doanhThu;
        public string MaSoChuyen { get => maSoChuyen; set => maSoChuyen = value; }
        public string HoTenTaiXe { get => hoTenTaiXe; set => hoTenTaiXe = value; }
        public string SoXe { get => soXe; set => soXe = value; }
        public double KhoiLuongHangHoa { get => khoiLuongHangHoa; set => khoiLuongHangHoa = value; }
        public double DoanhThu { get => doanhThu; set => doanhThu = value; }
        public TH_PHAN2_BAI2_Xe()
        {
            maSoChuyen = hoTenTaiXe = soXe = null;
            khoiLuongHangHoa = doanhThu = 0;
        }
        public TH_PHAN2_BAI2_Xe(string id, string name, string numXe, double quantity, double sales)
        {
            maSoChuyen = id;
            hoTenTaiXe = name;
            soXe = numXe;
            khoiLuongHangHoa = quantity;
            doanhThu = sales;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap thong tin ma so chuyen xe: ");
            maSoChuyen = Console.ReadLine();
            Console.Write("Nhap thong tin ho ten tai xe: ");
            hoTenTaiXe = Console.ReadLine();
            Console.Write("Nhap thong tin so xe: ");
            soXe = Console.ReadLine();
            Console.Write("Nhap thong tin khoi luong hang hoa: ");
            khoiLuongHangHoa = double.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin doanh thu: ");
            doanhThu = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format("Thong tin chuyen xe: \n\tMa so chuyen {0}\n\tHo ten tai xe: {1}\n\tSo xe: {2}\n\tKhoi luong hang hoa: {3}\n\tDoanh thu: {4}", maSoChuyen, hoTenTaiXe, soXe, khoiLuongHangHoa, doanhThu);
        }
    }
}
