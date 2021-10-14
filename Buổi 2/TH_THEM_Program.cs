using System;

namespace TH_THEM
{
    class TH_THEM_Program
    {
        static void Main(string[] args)
        {
            TH_THEM_Date date = new TH_THEM_Date(14, 10, 2021);
            Console.WriteLine(date);
            TH_THEM_Date date1 = ++date;
            Console.WriteLine(date1);
            if(date1 == date)
            {
                Console.WriteLine("Bang nhau");
            }
            if(date1 != date)
            {
                Console.WriteLine("Khac nhau");
            }
        }
    }
}
