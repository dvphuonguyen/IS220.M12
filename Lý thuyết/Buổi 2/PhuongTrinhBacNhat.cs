using System;


namespace PhuongTrinhBacNhat
{​​​​​
    class Program
    {​​​​​
        static void Main(string[] args)
        {​​​​​
            Console.WriteLine("Nhập vào a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {​​​​​
                if (b == 0) 
			Console.WriteLine("Phuong trinh co vo so nghiem");
                else 
			Console.WriteLine("Phuong trinh vo nghiem");
            }​​​​​
            else
            {​​​​​
                int x = -b / a;
                Console.WriteLine(" x = {​​​​​0}​​​​​", x);
            }​​​​​
        }​​​​​
    }​​​​​
}​​​​​