using System;

namespace BTVN_BAI4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguoi choi chon 1.KEO; 2.BUA; 3.BAO: ");
            int Person = int.Parse(Console.ReadLine());
            Random _ran = new Random();
            int Computer = _ran.Next(1, 3);
            Console.WriteLine("May tinh chon 1.KEO; 2.BUA; 3.BAO: " + Computer);
            switch (Person)
            {
                case 1:
                    switch (Computer)
                    {
                        case 1:
                            Console.WriteLine(Person + "vs" + Computer + "=> Hoa");
                            break;
                        case 2:
                            Console.WriteLine(Person + "vs" + Computer + "=> May tinh thang");
                            break;
                        case 3:
                            Console.WriteLine(Person + "vs" + Computer + "=> Nguoi choi thang");
                            break;
                    }
                    break;
                case 2:
                    switch (Computer)
                    {
                        case 1:
                            Console.WriteLine(Person + "vs" + Computer + "=> Nguoi choi thang");
                            break;
                        case 2:
                            Console.WriteLine(Person + "vs" + Computer + "=> Hoa");
                            break;
                        case 3:
                            Console.WriteLine(Person + "vs" + Computer + "=> May tinh thang");
                            break;
                    }
                    break;
                case 3:
                    switch (Computer)
                    {
                        case 1:
                            Console.WriteLine(Person + "vs" + Computer + "=> May tinh thang");
                            break;
                        case 2:
                            Console.WriteLine(Person + "vs" + Computer + "=> Nguoi choi thang");
                            break;
                        case 3:
                            Console.WriteLine(Person + "vs" + Computer + "=> Hoa");
                            break;
                    }
                    break;
            }
        }
    }
}
