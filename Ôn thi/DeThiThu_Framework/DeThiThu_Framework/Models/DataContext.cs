using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeThiThu_Framework.Models
{
    public class DataContext
    {
        public string ConnectionString { get; set; }
        public DataContext() { }
        public DataContext(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public int InsertCV(CongViec CV)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into congviec(macv, tencv, dongia) values(@a, @b, @c)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("a", CV.MaCV);
                cmd.Parameters.AddWithValue("b", CV.TenCV);
                cmd.Parameters.AddWithValue("c", CV.DonGia);
                return cmd.ExecuteNonQuery();
            }
        }
        public List<BaoDuong> LietKeBD(string soXe)
        {
            List<BaoDuong> list = new List<BaoDuong>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select * from BaoDuong where soxe = @sx";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("sx", soXe);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BaoDuong()
                        {
                            MaBD = reader["MABD"].ToString(),
                            NgayGioNhan = reader["ngaygionhan"].ToString(),
                            NgayGioTra = reader["ngaygiotra"].ToString(),
                            SoKM = reader["sokm"].ToString(),
                            NoiDung = reader["noidung"].ToString(),
                            SoXe = reader["soxe"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<CongViec> ViewCTBD(string Id)
        {
            List<CongViec> list = new List<CongViec>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select cv.macv, cv.tencv, cv.dongia from ct_bd join congviec cv on ct_bd.macv = cv.macv where mabd = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CongViec()
                        {
                            MaCV = reader["Macv"].ToString(),
                            TenCV = reader["tencv"].ToString(),
                            DonGia = Convert.ToInt32(reader["dongia"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public BaoDuong LayBD(string Id)
        {
            BaoDuong bd = new BaoDuong();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select * from baoduong where mabd = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bd = new BaoDuong()
                        {
                            MaBD = reader["MABD"].ToString(),
                            NgayGioNhan = reader["ngaygionhan"].ToString(),
                            NgayGioTra = reader["ngaygiotra"].ToString(),
                            SoKM = reader["sokm"].ToString(),
                            NoiDung = reader["noidung"].ToString(),
                            SoXe = reader["soxe"].ToString()
                        };
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return bd;
        }
        public int DeleteCVBD(string Id1, string Id2)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "delete from ct_bd where mabd = @a and macv = @b";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("a", Id1);
                cmd.Parameters.AddWithValue("b", Id2);
                return cmd.ExecuteNonQuery();
            }
        }
        public int TBUpdate(BaoDuong bd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "update baoduong set ngaygiotra= @nt where mabd = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", bd.MaBD);
                cmd.Parameters.AddWithValue("nt", bd.NgayGioTra);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
