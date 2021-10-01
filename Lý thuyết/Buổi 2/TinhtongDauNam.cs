using System;

namespace TinhTongDauNam
{​
    class Program
    {​
        static void Main(string[] args)
        {​
            int ngay;
            int thang;
            int nam;
            Console.Write("Nhap ngay: ");
            ngay = Convert.ToInt32(Console.ReadLine(););
            Console.Write("Nhap thang: ");
            thang = Convert.ToInt32(Console.ReadLine(););
            Console.Write("Nhap nam: ");
            nam= Convert.ToInt32(Console.ReadLine(););
            int sum = ngay;

            for (int i = 1; i < thang; i++)
            {​
                switch (thang)
                 {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        sum += 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        sum += 30;
                        break;
                    case 2:
                        if (((nam % 4 == 0) && (nam % 100 != 0)) || (nam % 400 == 0))
                        {​
                            sum += 29;
                            break;
                        }​
                        else
                        {​
                            sum += 28;
                            break;
                        }​
                    default:
                        Console.WriteLine("Thang khong hop le");
                        break;
                }​
            }​
            Console.WriteLine("So ngay tu dau nam {​0}​", sum);
        }​
    }​
}