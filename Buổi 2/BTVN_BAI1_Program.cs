using System;

namespace BTVN_BAI1
{
    class BTVN_BAI1_Program
    {
        static void Main(string[] args)
        {
            
            BTVN_BAI1_CustomerManager list = new BTVN_BAI1_CustomerManager();
            Console.WriteLine("-----------------------Nhap-----------------------");
            list.Nhap();
            Console.WriteLine("-----------------------Xuat-----------------------");
            Console.Write("Nhap thong tin thang can xuat hoa don: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin nam can xuat hoa don: ");
            int nam = int.Parse(Console.ReadLine());
            list.Xuat(thang, nam);
        }
    }
}
