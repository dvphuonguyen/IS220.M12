using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DangVuPhuongUyen_19520345.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; } 

        public StoreContext(string connectionString) 
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() 
        {
            return new MySqlConnection(ConnectionString);
        }

        //Them San Pham
        public int InsertSP(SanPham sanPham)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into SANPHAM(MASP, TENSP, DVT, NUOCSX, GIA) values(@masp, @tensp, @dvt, @nuocsx, @gia)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("masp", sanPham.MaSP);
                cmd.Parameters.AddWithValue("tensp", sanPham.TenSP);
                cmd.Parameters.AddWithValue("dvt", sanPham.DVT);
                cmd.Parameters.AddWithValue("nuocsx", sanPham.NuocSX);
                cmd.Parameters.AddWithValue("gia", sanPham.Gia);
                return (cmd.ExecuteNonQuery());
            }
        }

        //Liet Ke N San Pham
        public List<SanPham> LietKeCacSP(int SoSP)
        {
            List<SanPham> list = new List<SanPham>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SP.MASP, SP.TENSP, SP.DVT, SP.NUOCSX, SP.GIA from CTHD join SANPHAM SP on SP.MASP = CTHD.MASP group by  SP.MASP, SP.TENSP, SP.DVT, SP.NUOCSX, SP.GIA order by SUM(CTHD.SL) desc, SP.MASP asc limit @slsp";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("slsp", SoSP);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SanPham()
                        {
                            MaSP = reader["MASP"].ToString(),
                            TenSP = reader["TENSP"].ToString(),
                            DVT = reader["DVT"].ToString(),
                            NuocSX = reader["NUOCSX"].ToString(),
                            Gia = Convert.ToInt32(reader["GIA"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        //Liet Ke Hoa Don Cua Nhan Vien
        public List<HoaDon> LietKeCacHD(string manv)
        {
            List<HoaDon> list = new List<HoaDon>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from Hoadon where MaNV=@manv";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manv", manv);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDon()
                        {
                            SoHD = reader["SOHD"].ToString(),
                            NgayHD = reader["NGHD"].ToString(),
                            MaKH = reader["MAKH"].ToString(),
                            MaNV = reader["MANV"].ToString(),
                            Trigia = Convert.ToInt32(reader["TRIGIA"]),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        //Liet ke cac nhan vien
        public List<NhanVien> LietKeNV()
        {
            List<NhanVien> list = new List<NhanVien>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from nhanvien";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVien()
                        {
                            MaNV = reader["MaNV"].ToString(),
                            HoTen = reader["HOTEN"].ToString(),
                            SoDT = reader["SoDT"].ToString(),
                            NgVL = Convert.ToDateTime(reader["NGVL"]),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        //Xoa hoa don
        public void DeleteCTHD(string id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from CTHD where sohd=@SOHD";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("sohd", id);
                cmd.ExecuteNonQuery();
            }
        }
        public int DeleteHD(string id)
        {
            DeleteCTHD(id);
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from hoadon where sohd=@SOHD";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("sohd", id);
                return (cmd.ExecuteNonQuery());
            }
        }
        //Hien thi hoa don
        public HoaDon ViewHD(string id)
        {
            HoaDon hd = new HoaDon();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from hoadon where sohd=@sohd";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("sohd", id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    hd.SoHD = reader["SOHD"].ToString();
                    hd.NgayHD = reader["NGHD"].ToString();
                    hd.MaKH = reader["MAKH"].ToString();
                    hd.MaNV = reader["MANV"].ToString();
                    hd.Trigia = Convert.ToInt32(reader["TRIGIA"]);
                }
            }
            return (hd);
        }
    }
}
