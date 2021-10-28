using System;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace MyConnection
{
    class Program
    {
        public static void Cau1(MySqlConnection conn)
        {
            var sql = "UPDATE SANPHAM SET GIA=GIA*1.05 WHERE NUOCSX = 'Thai Lan' ";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public static void Cau2(MySqlConnection conn)
        {
            var sql = "UPDATE SANPHAM SET GIA=GIA*0.95 WHERE NUOCSX = 'Trung Quoc' AND GIA<10000 ";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public static void Cau3(MySqlConnection conn)
        {
            string sql = "select MASP, TENSP from SANPHAM where NUOCSX = 'Trung Quoc'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
                if (reader.HasRows)
                {
                Console.WriteLine("MASP \tTENSP");
                while (reader.Read())
                {
                    int indexSOHD = reader.GetOrdinal("MASP");
                    string SOHD = reader.GetString(indexSOHD);
                    Console.Write(SOHD + "\t");
                    int indexTRIGIA = reader.GetOrdinal("TENSP");
                    string TRIGIA = reader.GetString(indexTRIGIA);
                    Console.Write(TRIGIA + "\n");
                }
                }
            }
        }
        
        public static void Cau4(MySqlConnection conn)
        {
            string sql = "select MASP, TENSP from SANPHAM where DVT in ('cay', 'quyen')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
                if (reader.HasRows)
                {
                Console.WriteLine("MASP \tTENSP");
                while (reader.Read())
                {
                    int indexSOHD = reader.GetOrdinal("MASP");
                    string SOHD = reader.GetString(indexSOHD);
                    Console.Write(SOHD + "\t");
                    int indexTRIGIA = reader.GetOrdinal("TENSP");
                    string TRIGIA = reader.GetString(indexTRIGIA);
                    Console.Write(TRIGIA + "\n");
                }
                }
            }
        }
        
        public static void Cau5(MySqlConnection conn)
        {
            string sql = "select MASP, TENSP  from SANPHAM where MASP like 'B%01'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
                if (reader.HasRows)
                {
                Console.WriteLine("MASP \tTENSP");
                while (reader.Read())
                {
                    int indexSOHD = reader.GetOrdinal("MASP");
                    string SOHD = reader.GetString(indexSOHD);
                    Console.Write(SOHD + "\t");
                    int indexTRIGIA = reader.GetOrdinal("TENSP");
                    string TRIGIA = reader.GetString(indexTRIGIA);
                    Console.Write(TRIGIA + "\n");
                }
                }
            }
        }
        
        public static void Cau6(MySqlConnection conn)
        {
            string sql = "select MASP, TENSP from SANPHAM where NUOCSX = 'Trung Quoc' and GIA >= 30000 and GIA <= 40000";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
                if (reader.HasRows)
                {
                Console.WriteLine("MASP \tTENSP");
                while (reader.Read())
                {
                    int indexSOHD = reader.GetOrdinal("MASP");
                    string SOHD = reader.GetString(indexSOHD);
                    Console.Write(SOHD + "\t");
                    int indexTRIGIA = reader.GetOrdinal("TENSP");
                    string TRIGIA = reader.GetString(indexTRIGIA);
                    Console.Write(TRIGIA + "\n");
                }
                }
            }
        }
        
        public static void Cau7(MySqlConnection conn)
        {
            string sql = "select MASP, TENSP from SANPHAM where NUOCSX in ('Trung Quoc', 'Thai Lan') and GIA >= 30000 and GIA <= 40000";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
                if (reader.HasRows)
                {
                Console.WriteLine("MASP \tTENSP");
                while (reader.Read())
                {
                    int indexSOHD = reader.GetOrdinal("MASP");
                    string SOHD = reader.GetString(indexSOHD);
                    Console.Write(SOHD + "\t");
                    int indexTRIGIA = reader.GetOrdinal("TENSP");
                    string TRIGIA = reader.GetString(indexTRIGIA);
                    Console.Write(TRIGIA + "\n");
                }
                }
            }
        }
        

        public static void Cau8(MySqlConnection conn)
        {
            string sql = "select SOHD, TRIGIA from HOADON where NGHD  = '1/1/2007' or NGHD  ='02/01/2007'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
                if (reader.HasRows)
                {
                Console.WriteLine("SOHD \tTRIGIA");
                while (reader.Read())
                {
                    int indexSOHD = reader.GetOrdinal("SOHD");
                    string SOHD = reader.GetString(indexSOHD);
                    Console.Write(SOHD + "\t");
                    int indexTRIGIA = reader.GetOrdinal("TRIGIA");
                    string TRIGIA = reader.GetString(indexTRIGIA);
                    Console.Write(TRIGIA + "\n");
                }
                }
            }
        }

            
        public static void cau9(MySqlConnection conn)
        {​​​​​​
            string sql = "select SOHD, TRIGIA from HOADON where MONTH(NGHD)= 1 and YEAR(NGHD) = 2007 order by NGHD asc , TRIGIA desc";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("Ma hoa don \t Tri gia \t");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TRIGIA"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }​​​​​​
            }​​​​​​
        }​​​​​​


        public static void Cau10(MySqlConnection conn)
        {
            string sql = "select kh.MAKH, HOTEN from KHACHHANG kh join HOADON hd on kh.MAKH = hd.MAKH where NGHD = '1/1/2007'";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("Ma hoa don \t Tri gia \t");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TRIGIA"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }​​​​​​
            }
        }

        public static void cau11(MySqlConnection conn)
        {​​​​​​
            string sql = "select SOHD, TRIGIA from HOADON hd join NHANVIEN nv on hd.MANV = nv.MANV where HOTEN = 'Nguyen Van B' and NGHD = '28/10/2006'";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("Ma hoa don \t Tri gia \t");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TRIGIA"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }​
        


        public static void cau12(MySqlConnection conn)
        {​​​​​​
            string sql = "select sp.MASP, TENSP from SANPHAM sp join CTHD on CTHD.MASP = sp.MASP join HOADON hd on hd.SOHD = CTHD.SOHD join KHACHHANG kh on kh.MAKH = hd.MAKH where HOTEN = 'Nguyen Van A' and MONTH(NGHD) = 10 and YEAR(NGHD) = 2006";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("Ma san pham \t Ten san pham \t");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("sp.MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau13(MySqlConnection conn)
        {​​​​​​
            string sql = "select distinct SOHD from CTHD where MASP  = 'BB01' or MASP  = 'BB02'";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("So hoa don");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau14(MySqlConnection conn)
        {​​​​​​
            string sql = "select distinct SOHD from CTHD where (MASP  = 'BB01' or MASP  = 'BB02') and SL between 10 and 20";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("So hoa don");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau15(MySqlConnection conn)
        {​​​​​​
            string sql = "select distinct SOHD from CTHD where SL between 10 and 20 and MASP = 'BB01' and SOHD in (select SOHD from CTHD where MASP ='BB02')";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("So hoa don");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau16(MySqlConnection conn)
        {​​​​​​
            string sql = "SELECT MASP,TENSP FROM SANPHAM WHERE NUOCSX = 'TRUNG QUOC' UNION SELECT sp.MASP, sp.TENSP FROM SANPHAM sp, HOADON hd, CTHD  WHERE hd.SOHD = CTHD.SOHD AND CTHD.MASP = sp.MASP AND NGHD = '1/1/2007'";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("Ma san pham \t Ten san pham \t");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("sp.MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau17(MySqlConnection conn)
        {​​​​​​
            string sql = "SELECT MASP, TENSP FROM SANPHAM WHERE MASP NOT IN(SELECT MASP FROM CTHD)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("Ma san pham \t Ten san pham \t");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau18(MySqlConnection conn)
        {​​​​​​
            string sql = "select sp.MASP, TENSP from SANPHAM sp where sp.MASP not in (select CTHD.MASP from CTHD join HOADON hd on hd.SOHD = CTHD.SOHD where YEAR(NGHD) = 2006) ";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("Ma san pham \t Ten san pham \t");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("sp.MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau19(MySqlConnection conn)
        {​​​​​​
            string sql = "select sp.MASP, TENSP from SANPHAM sp where NUOCSX ='Trung Quoc' and sp.MASP not in (select CTHD.MASP from CTHD join HOADON hd on hd.SOHD = CTHD.SOHD where YEAR(NGHD) = 2006)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("Ma san pham \t Ten san pham \t");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("sp.MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau20(MySqlConnection conn)
        {​​​​​​
            string sql = "select SOHD from HOADON hd where not exists ( select * from SANPHAM sp where NUOCSX = 'Singapore' and not exists ( select * from CTHD where CTHD.MASP = sp.MASP and CTHD.SOHD = hd.SOHD))";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("So hoa don");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau21(MySqlConnection conn)
        {​​​​​​
            string sql = "select SOHD from HOADON hd where YEAR(NGHD) = 2006 and not exists ( select * from SANPHAM sp where NUOCSX = 'Singapore' and not exists ( select * from CTHD where CTHD.MASP = sp.MASP and CTHD.SOHD = hd.SOHD))";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("So hoa don");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau22(MySqlConnection conn)
        {​​​​​​
            string sql = "select count(*) SLHOADON_KHONGCOPHAIKHTV from HOADON where MAKH is NULL";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("So luong hoa don khog phai khach hang thanh vien mua");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SLHOADON_KHONGCOPHAIKHTV"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id= + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau23(MySqlConnection conn)
        {​​​​​​
            string sql = "select count(distinct MASP) SL_SANPHAM from CTHD join HOADON hd on hd.SOHD = CTHD.SOHD where YEAR(NGHD) = 2006";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("So luong san pham khac nhau khong ban duoc nam 2006");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SL_SANPHAM"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id= + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau24(MySqlConnection conn)
        {​​​​​​
            string sql = "select max(TRIGIA) max_TRIGIA, min(TRIGIA) min_TRIGIA from HOADON";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("MAX \t MIN");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("max_TRIGIA"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("min_TRIGIA"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau25(MySqlConnection conn)
        {​​​​​​
            string sql = "select avg(TRIGIA) avg_TRIGIA from HOADON where YEAR(NGHD) = 2006";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("AVG");
                    while (reader.Read())
                    {​​​​​​
                        int indexid = reader.GetOrdinal("avg_TRIGIA"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau26(MySqlConnection conn)
        {​​​​​​
            string sql = "Select sum(TRIGIA) DOANHTHU from HOADON where YEAR(NGHD) = 2006";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("SUM");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("DOANHTHU"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau27(MySqlConnection conn)
        {​​​​​​
            string sql = "select max(TRIGIA) max_TRIGIA from HOADON where YEAR(NGHD) = 2006";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("MAX");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("max_TRIGIA"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau28(MySqlConnection conn)
        {​​​​​​
            string sql = "select kh.MAKH, HOTEN from KHACHHANG kh join HOADON hd on kh.MAKH = hd.MAKH where YEAR(NGHD) = 2006 and TRIGIA =(	select max(TRIGIA) from HOADON)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("kh.MAKH \t HOTEN");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("kh.MAKH"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("HOTEN"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau29(MySqlConnection conn)
        {​​​​​​
            string sql = "select MAKH, HOTEN from KHACHHANG where DOANHSO in (	select top 3 DOANHSO from KHACHHANG order by DOANHSO desc)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("MAKH \t HOTEN");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("MAKH"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("HOTEN"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau30(MySqlConnection conn)
        {​​​​​​
            string sql = "select MASP, TENSP from SANPHAM sp where GIA in (select distinct top 3  GIA from SANPHAM order by GIA desc)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("MASP\t TENSP");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau31(MySqlConnection conn)
        {​​​​​​
            string sql = "select MASP, TENSP from SANPHAM sp  where NUOCSX = 'Thai Lan' and GIA in (select distinct top 3  GIA from SANPHAM order by GIA desc)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("MASP\t TENSP");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau32(MySqlConnection conn)
        {​​​​​​
            string sql = "select MASP, TENSP from SANPHAM sp  where NUOCSX = 'Trung Quoc' and GIA in (select distinct top 3  GIA from SANPHAM where NUOCSX = 'Trung Quoc' order by GIA desc)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("MASP\t TENSP");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau33(MySqlConnection conn)
        {​​​​​​
            string sql = "select MAKH, HOTEN from KHACHHANG where DOANHSO in (select top 3 DOANHSO from KHACHHANG order by DOANHSO desc )";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("MAKH\t HOTEN");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("MAKH"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("HOTEN"); // 1
                        int name = reader.GetInt32(indexname);
                        Console.Write(name + "\n");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau34(MySqlConnection conn)
        {​​​​​​
            string sql = "select count(MASP) count_sp_TQ from SANPHAM where NUOCSX = 'Trung Quoc'";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("TONG SAN PHAM DO TRUNG QUOC SAN XUAT");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("count_sp_TQ"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau35(MySqlConnection conn)
        {​​​​​​
            string sql = "select NUOCSX, count(MASP) count_sp from SANPHAM group by NUOCSX ";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("NUOCSX\tcount_sp");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("NUOCSX"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("count_sp"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau36(MySqlConnection conn)
        {​​​​​​
            string sql = "select NUOCSX, max(Gia) max_Gia, avg(Gia) avg_Gia from SANPHAM group by NUOCSX ";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("NUOCSX\tmax_Gia\tavg_Gia");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("NUOCSX"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("max_Gia"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                        int indexname1 = reader.GetOrdinal("avg_Gia"); // 0
                        string name1 = reader.GetString(indexname1);
                        Console.Write(name1 + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau37(MySqlConnection conn)
        {​​​​​​
            string sql = "select NGHD, sum(TRIGIA) DOANHTHU from HOADON group by NGHD";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("NGHD\tDOANHTHU");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("NGHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("DOANHTHU"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau38(MySqlConnection conn)
        {​​​​​​
            string sql = "select MASP, sum(SL) Tong_SL from CTHD join HOADON hd on CTHD.SOHD = hd.SOHD where MONTH(NGHD) = 10 and YEAR(NGHD) = 2006 group by MASP";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("MASP\tTong_SL");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("Tong_SL"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau39(MySqlConnection conn)
        {​​​​​​
            string sql = "select MONTH(NGHD) THANG, sum(TRIGIA) DOANHTHU from HOADON group by MONTH(NGHD)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("THANG\tDOANHTHU");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("THANG"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("DOANHTHU"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau40(MySqlConnection conn)
        {​​​​​​
            string sql = "select SOHD, count(MASP) COUNT_SP from CTHD group by SOHD having count(MASP) >= 4";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("SOHD\tCOUNT_SP");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("COUNT_SP"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau41(MySqlConnection conn)
        {​​​​​​
            string sql = "select SOHD  from CTHD join SANPHAM sp on sp.MASP = CTHD.MASP where NUOCSX = 'Viet Nam' group by SOHD  having count (sp.MASP) = 3";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("SOHD");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("SOHD"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau42(MySqlConnection conn)
        {​​​​​​
            string sql = "select kh.MAKH, HOTEN from KHACHHANG kh join HOADOn hd on hd.MAKH = kh.MAKH group by  kh.MAKH";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("kh.MAKH\tHOTEN");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("kh.MAKH"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("HOTEN"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau43(MySqlConnection conn)
        {​​​​​​
            string sql = "select MONTH(NGHD) THANG, sum(TRIGIA) DOANHTHU from HOADON where YEAR(NGHD) =2006 group by MONTH(NGHD) having sum(TRIGIA) >= all (select sum(TRIGIA) from HOADON where YEAR(NGHD) =2006 group by MONTH(NGHD))";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("THANG\tDOANHTHU");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("THANG"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("DOANHTHU"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau44(MySqlConnection conn)
        {​​​​​​
            string sql = "select sp.MASP, TENSP 
                        +"from SANPHAM sp join CTHD cthd on cthd.MASP = sp.MASP join HOADON hd on hd.SOHD = cthd.SOHD"
                        +"where YEAR(NGHD) = 2006" 
                        +"group by sp.MASP, TENSP "
                        +"having sum(SL) <= all (select sum(SL)"
                                                +"rom CTHD join HOADON on HOADON.SOHD = CTHD.SOHD"
                                                +"where YEAR(NGHD) = 2006 "
                                                +"group by MASP)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("sp.MASP\tTENSP");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("sp.MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau45(MySqlConnection conn)
        {​​​​​​
            string sql = "select MASP, TENSP from SANPHAM a where GIA >= all (select GIA from SANPHAM b where a.NUOCSX = b.NUOCSX ) group by NUOCSX, MASP, TENSP";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("MASP\tTENSP");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("MASP"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("TENSP"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau46(MySqlConnection conn)
        {​​​​​​
            string sql = "select NUOCSX from SANPHAM group by NUOCSX having count(distinct GIA) >= 3";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("NUOCSX");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("NUOCSX"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                    }​​​​​​
                }
            }​​​​​
        }

        public static void cau47(MySqlConnection conn)
        {​​​​​​
            string sql = "select kh.MAKH, kh.HOTEN"
                        +"from KHACHHANG kh join ( select top 10 *"
                                                +"from KHACHHANG"
                                                +"order by DOANHSO desc"
                                                +") as j on kh.MAKH = j.MAKH join HOADON hd on hd.MAKH = j.MAKH"
                        +"group by kh.MAKH, kh.HOTEN"
                        +"having count(SOHD) >= all (select count(SOHD)"
                                                    +"from HOADON hd1 join (select top 10 *"
                                                                        +"from KHACHHANG "
                                                                        +"order by DOANHSO desc"
                                                                        +") as kh1 on kh1.MAKH = hd1.MAKH"
                                                    +"group";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {​​​​​​
                if (reader.HasRows)
                {​​​​​​
                    Console.WriteLine("kh.MAKH\tkh.HOTEN");
                    {​​​​​​
                        int indexid = reader.GetOrdinal("kh.MAKH"); // 0
                        string id = reader.GetString(indexid);
                        Console.Write(id + "\t");
                        int indexname = reader.GetOrdinal("kh.HOTEN"); // 0
                        string name = reader.GetString(indexname);
                        Console.Write(name + "\t");
                    }​​​​​​
                }
            }​​​​​
        }


        static void Main(string[] args)
        {

            MySqlConnection conn = ConnectData.GetConnection();
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                //Nhập hàm cần chạy
                //Ví dụ: nếu muốn chạy hàm Cau1 thì nhập như sau: 
                Cau1(conn);
                //Tổng cộng có từ 1 - > 47 hàm

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.Read();
        }
    }
}
