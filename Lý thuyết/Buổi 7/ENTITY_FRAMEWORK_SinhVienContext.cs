using System;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameWork
{
    public class SinhVienContext: DbContext
    {

        private const string connectionString ="server=localhost;port=3306;database=quanlysinhvien; uid=root;password=";

        //internal object products;

        //private const string connectionString = "";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(connectionString);
        }

        public DbSet<SinhVien> SinhVien { set; get; }  

    }
}
