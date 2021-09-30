using System;

namespace BTVN_BAI1
{
    class Program
    {
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
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
                    else
                    {
                        b -= a;
                    }
                }
                return a;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Uoc chung lon nhat cua hai so la: " + UCLN(num1, num2));
        }
    }
}
