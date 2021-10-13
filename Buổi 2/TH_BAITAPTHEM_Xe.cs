using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_BAITAPTHEM
{
    class Xe
    {
        private double luongXang, luongHang, quangDuong;
        public double LuongXang
        {
            get { return luongXang; }
            set { luongXang = value; }
        }
        public double LuongHang
        {
            get { return luongHang; }
            set { luongHang = value; }
        }
        public double QuangDuong
        {
            get { return quangDuong; }
            set { quangDuong = value; }
        }
        public Xe()
        {
            luongXang = luongHang = quangDuong = 0;
        }
        public Xe(double lxang, double lhang)
        {
            luongXang = lxang;
            luongHang = lhang;
            quangDuong = 0;
        }
        public virtual void ChatHang(double themHang)
        {
            luongHang += themHang;
        }
        public virtual void BotHang(double botHang)
        {
            if (botHang > 0 && botHang<= luongHang)
            {
                luongHang -= botHang;
            }
            else
            {
                Console.WriteLine("Luong hang con bot vuot qua luonghang co tren xe");
            }
        }
        public virtual void DoXang(double themXang)
        {
            luongXang += themXang;
        }
        public virtual void ChayTrenDuong(double chayThem)
        {
            quangDuong += chayThem;
        }
        public virtual void TinhXang() { }
        public virtual bool HetXang()
        {
            return true;
        }
        public override string ToString()
        {
            return string.Format("Luong hang: {0} kg.\tLuong xang: {1} lit.\tQuang duong: {2} km.", luongHang, luongXang, quangDuong);
        }
    }
}
