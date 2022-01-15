using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1920_QuanLyDiemCachLy.Models
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

        public int InsertDCL(DiemCachLy dcl)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into diemcachly (madiemcachly, tendiemcachly,diachi) values(@ma, @ten, @chi)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ma", dcl.MaDiemCachLy);
                cmd.Parameters.AddWithValue("ten", dcl.TenDiemCachLy);
                cmd.Parameters.AddWithValue("chi", dcl.DiaChi);
                return cmd.ExecuteNonQuery();
            }
        }//select tencongnhan, namsinh, nuocve, count(cn_tc.matrieuchung) sotrieuchung from congnhan cn join cn_tc on cn.macongnhan = Cn_TC.macongnhan group by tencongnhan, namsinh, nuocve having count(matrieuchung) >= 2
        public List<DiemCachLy> ComboBoxDCL( )
        {
            List<DiemCachLy> list = new List<DiemCachLy>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select * from diemcachly";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DiemCachLy()
                        {
                            MaDiemCachLy = reader["MaDiemCachLy"].ToString(),
                            TenDiemCachLy = reader["TenDiemCachLy"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<object> LietKeSL( int soLan)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select tencongnhan, namsinh, nuocve, count(cn_tc.matrieuchung) sotrieuchung from congnhan cn join cn_tc on cn.macongnhan = Cn_TC.macongnhan group by tencongnhan, namsinh, nuocve having count(matrieuchung) >= @soLan";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("soLan", soLan);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            TenCongNhan = reader["TenCongNhan"].ToString(),
                            NamSinh = Convert.ToInt32(reader["NamSinh"]),
                            NuocVe = reader["NuocVe"].ToString(),
                            SoTrieuChung = Convert.ToInt32(reader["sotrieuchung"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<CongNhan> LietKeCN(string MaDiemCachLy)
        {
            List<CongNhan> list = new List<CongNhan>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select * from CongNhan cn where madiemcachly = @MaDiemCachLy";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("MaDiemCachLy", MaDiemCachLy);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CongNhan()
                        {
                            MaCongNhan = reader["MaCongNhan"].ToString(),
                            TenCongNhan = reader["TenCongNhan"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public CongNhan ViewCN(string MaCongNhan)
        {
            CongNhan list = new CongNhan();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "select * from CongNhan cn where maCongNhan = @MaCongNhan";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("MaCongNhan", MaCongNhan);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list = (new CongNhan(){
                            MaCongNhan = reader["MaCongNhan"].ToString(),
                            TenCongNhan = reader["TenCongNhan"].ToString(),
                            GioiTinh = Convert.ToBoolean(reader["GioiTinh"]),
                            NamSinh = Convert.ToInt32(reader["NamSinh"]),
                            NuocVe = reader["NuocVe"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int DeleteCN(string MaCongNhan)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "delete from congnhan where macongnhan = @MaCongNhan";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("MaCongNhan", MaCongNhan);
                return cmd.ExecuteNonQuery();
            }
        }
        public int UpdateCN(CongNhan cn)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "update congnhan set TenCongNhan = @TenCongNhan and GioiTinh = @GioiTinh where macongnhan = @MaCongNhan";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("MaCongNhan", cn.MaCongNhan);
                cmd.Parameters.AddWithValue("TenCongNhan", cn.TenCongNhan);
                cmd.Parameters.AddWithValue("GioiTinh", cn.GioiTinh);
                cmd.Parameters.AddWithValue("NamSinhn", cn.NamSinh);
                cmd.Parameters.AddWithValue("NuocVe", cn.NuocVe);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
