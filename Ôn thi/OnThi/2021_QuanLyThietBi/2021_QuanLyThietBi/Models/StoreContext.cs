using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_QuanLyThietBi.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }
        public StoreContext() { }
        public StoreContext(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public int InsertCH(CanHo ch)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into canho(macanho, tenchuho) values(@mch, @tch)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mch", ch.MaCanHo);
                cmd.Parameters.AddWithValue("tch", ch.TenChuHo);
                return cmd.ExecuteNonQuery();
            }
        }
        public List<object> LietKeSL(int soLan)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();;
                var sql = " SELECT TenNhanVien, SoDienThoai, COUNT(*) as SoLanSua FROM nhanvien nv INNER JOIN nv_bt on nv.MaNhanVien = nv_bt.MaNhanVien GROUP BY nv.MaNhanVien HAVING COUNT(*) >= @sl";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("sl", soLan);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            TenNhanVien = reader["TenNhanVien"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            SoLanSua = Convert.ToInt32(reader["SoLanSua"])
                        }); 
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<NhanVien> ComboBoxNV()
        {
            List<NhanVien> list = new List<NhanVien>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select * from nhanvien";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVien()
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            TenNhanVien = reader["TenNhanVien"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<NV_TB> LietKeNVTB(string MaNhanVien)
        {
            List<NV_TB> list = new List<NV_TB>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select nv.manhanvien, mathietbi, macanho, ngaybaotri, lanthu from nhanvien nv join nv_BT on nv.manhanvien = nv_BT.manhanvien where nv.manhanvien = @ma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ma", MaNhanVien);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NV_TB()
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            MaThietBi = reader["MaThietBi"].ToString(),
                            MaCanHo = reader["MaCanHo"].ToString(),
                            LanThu= Convert.ToInt32(reader["LanThu"]),
                            NgayBaoTri = Convert.ToDateTime(reader["NgayBaoTri"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
       public int DeleteNVTB(string Id1, string Id2, string Id3, string Id4)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "delete from nv_bt where manhanvien = @nv and mathietbi = @tb and macanho = @ch and lanthu = @lt";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nv", Id1);
                cmd.Parameters.AddWithValue("tb", Id2);
                cmd.Parameters.AddWithValue("ch", Id3);
                cmd.Parameters.AddWithValue("lt", Id4);
                return cmd.ExecuteNonQuery();
            }
        }

        public NV_TB ViewNVTB(string Id1, string Id2, string Id3, string Id4)
        {
            NV_TB list = new NV_TB();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select manhanvien, mathietbi, macanho, ngaybaotri, lanthu from nv_BT  where manhanvien = @id1 and mathietbi = @id2 and macanho = @id3 and lanthu = @id4";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id1", Id1);
                cmd.Parameters.AddWithValue("id2", Id2);
                cmd.Parameters.AddWithValue("id3", Id3);
                cmd.Parameters.AddWithValue("id4", Id4);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list = (new NV_TB()
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            MaThietBi = reader["MaThietBi"].ToString(),
                            MaCanHo = reader["MaCanHo"].ToString(),
                            LanThu = Convert.ToInt32(reader["LanThu"]),
                            NgayBaoTri = Convert.ToDateTime(reader["NgayBaoTri"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int UpdateNVTB( NV_TB nvtb)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "update nv_bt set ngaybaotri = @NGAYBAOTRI, lanthu = @LANTHU where manhanvien = @MANHANVIEN and mathietbi = @MATHIETBI and macanho = @MACANHO ;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("NGAYBAOTRI", nvtb.NgayBaoTri);
                cmd.Parameters.AddWithValue("MANHANVIEN", nvtb.MaNhanVien);
                cmd.Parameters.AddWithValue("MATHIETBI", nvtb.MaThietBi);
                cmd.Parameters.AddWithValue("MACANHO", nvtb.MaCanHo);
                cmd.Parameters.AddWithValue("LANTHU", nvtb.LanThu);
                return cmd.ExecuteNonQuery();

                return cmd.ExecuteNonQuery();
            }
        }
    }
}

