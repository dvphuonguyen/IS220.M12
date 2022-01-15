using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1920_QuanLyDiemCachLy.Models
{
    public class CongNhan
    {
        public string MaCongNhan { get; set; }
        public string TenCongNhan { get; set; }
        public bool GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string NuocVe { get; set; }
        public string MaDiemCachLy { get; set; }
    }
}
