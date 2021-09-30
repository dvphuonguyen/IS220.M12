using System;

namespace TH_BAI2_STRUCT
{
    class PhanSo
    {
        struct PhanSo
        {
            public int tuSo, mauSo;
        }
        static int UCLN(int a, int b)
        {
            if (a ==0 || b == 0)
            {
                return a + b;
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else{
                        b -= a;
                    }
                }
                return a;
            }
        }
        static void XuatRutGon(PhanSo a)
        {
            int ucln = UCLN(a.tuSo, a.mauSo);
            a.tuSo /= ucln;
            a.mauSo /= ucln;
            if (a.mauSo == 0)
            {
            }
            else if (a.tuSo == 0 || a.mauSo == 1)
            {
                Console.WriteLine(a.tuSo); 
            }
            else
            {
                Console.WriteLine("{0} / {1}", a.tuSo, a.mauSo);
            }
        }
        static void Main(string[] args)
        {
            PhanSo ps1, ps2, ps3;
            int ucln;
            Console.WriteLine("-----------Nhap phan so thu nhat:-----------");
            Console.WriteLine("Nhap tu so: ");
            ps1.tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            ps1.mauSo = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------Nhap phan so thu hai:-----------");
            Console.WriteLine("Nhap tu so: ");
            ps2.tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            ps2.mauSo = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------Tong:-----------");
            ps3.tuSo = ps1.tuSo * ps2.mauSo + ps1.mauSo * ps2.tuSo;
            ps3.mauSo = ps1.tuSo * ps2.mauSo;
            Console.Write("Tong hai phan so: ");
            XuatRutGon(ps3);

            Console.WriteLine("-----------Hieu:-----------");
            ps3.tuSo = ps1.tuSo * ps2.mauSo - ps1.mauSo * ps2.tuSo;
            ps3.mauSo = ps1.tuSo * ps2.mauSo;
            Console.Write("Hieu hai phan so: ");
            XuatRutGon(ps3);

            Console.WriteLine("-----------Tich:-----------");
            ps3.tuSo = ps1.tuSo * ps2.tuSo;
            ps3.mauSo = ps1.tuSo * ps2.mauSo;
            Console.Write("Tich hai phan so: ");
            XuatRutGon(ps3);

            Console.WriteLine("-----------Thuong:-----------");
            ps3.tuSo = ps1.tuSo * ps2.mauSo ;
            ps3.mauSo = ps1.mauSo * ps2.tuSo;
            Console.Write("Thuong hai phan so: ");
            XuatRutGon(ps3);
        }
    }
}
