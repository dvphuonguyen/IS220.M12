using System;

namespace DemNut
{​​​​​
    class Program
    {​​​​​
        static void Main(string[] args)
        {​​​​​
            int n;
            int sotachra;
            int s = 0;
            Console.ReadLine("Nhap n: ");
            Console.WriteLine("%d", &n);
            for (; n != 0;)
            {​​​​​
                sotachra = n % 10;
                s += sotachra;
                n /= 10;
            }​​​​​
            Console.WriteLine("%d", s);
        }​​​​​
    }​​​​​
}​​​​​