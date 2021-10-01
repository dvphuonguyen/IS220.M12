using System;

namespace NgayThangNam{
     class HelloWorld {​​​​​
  	static void Main() {​​​​​
            Console.Write("Nhap thang : ");
            int th = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam : ");
            string nam = Console.ReadLine();
            int nm = int.Parse(Console.ReadLine());
            int songay = 0;
            if (th >= 1 && th <= 12)
            {​​​​​
                switch (th)
                {​​​​​
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;
                    case 2:
                        if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))   
                            songay = 29;
                        else
                            songay = 28;
                        break;
                    default:
                        songay = 31; break;
                        break;
                }​​​​​
 
                Console.Write(songay+" ngay\n");
            }​​​​​
            else
                Console.Write("Thang khong hop le!\n");
            Console.ReadLine();
  }​​​​​
}​​​​​