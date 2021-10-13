using System;

namespace TH_BAITAPTHEM
{
    class Program
    {
        static void ChuyenDi(Xe xe)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:\n\t0: Thoat\n\t1: Chat hang\n\t2: Bot hang\n\t3: Do xang\n\t4: Xe chay tren duong\n\t5: Kiem tra het xang\n\t6: Luong xang con lai");
                Console.Write("Nhap lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Them hang len xe: ");
                        double themHang = double.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------Them hang--------------------");
                        xe.ChatHang(themHang);
                        Console.WriteLine(xe);
                        break;
                    case 2:
                        Console.Write("Bot hang khoi xe: ");
                        double botHang = double.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------Bot hang--------------------");
                        xe.BotHang(botHang);
                        Console.WriteLine(xe);
                        break;
                    case 3:
                        Console.Write("Do xang cho xe: ");
                        double themXang = double.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------Do xang--------------------");
                        xe.DoXang(themXang);
                        Console.WriteLine(xe);
                        break;
                    case 4:
                        Console.Write("Quang duong xe chay: ");
                        double chayThem = double.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------Chay tren duong--------------------");
                        xe.ChayTrenDuong(chayThem);
                        Console.WriteLine(xe);
                        break;
                    case 5:
                        Console.WriteLine("--------------------Kiem tra het xang--------------------");
                        if (xe.HetXang() == true)
                        {
                            Console.WriteLine("Xe het xang");
                        }
                        else
                        {
                            Console.WriteLine("Xe con xang");
                        }
                        break;
                    case 6:
                        Console.WriteLine("--------------------Luong xang con lai--------------------");
                        xe.TinhXang();
                        Console.WriteLine("Luong xang con lai: {0}", xe.LuongXang);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:\n\t0:Thoat\n\t1:Xe may\n\t2:Xe tai");
                Console.Write("Nhap lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());
                Xe xe;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("--------------------Xe May--------------------");
                        xe = new XeMay();
                        ChuyenDi(xe);
                        break;
                    case 2:
                        Console.WriteLine("--------------------Xe Tai--------------------");
                        xe = new XeTai();
                        ChuyenDi(xe);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }
    }
}
