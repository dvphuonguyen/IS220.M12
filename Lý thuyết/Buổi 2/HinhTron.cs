using System;


namespace Buoi2
{​​​​​
    class Program
    {​​​​​
        static void Main(string[] args)
        {​​​​​
            Console.Write("Nhap ban kinh: ");
            double banKinh = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Dien tich hinh tron", banKinh * banKinh * Math.PI);
            Console.WriteLine("Chu vi hinh tron", banKinh * 2 * Math.PI);
        }​​​​​
    }​​​​​
}​​​​​
 