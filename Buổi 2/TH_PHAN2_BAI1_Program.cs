using System;

namespace TH_PHAN2_BAI2
{
    class TH_PHAN2_BAI1_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Person------------");
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            int age = int.Parse(Console.ReadLine());
            TH_PHAN2_BAI1_Person person = new TH_PHAN2_BAI1_Person(name, age);
            person.Show();

            Console.WriteLine("------------Employee------------");
            Console.Write("Nhap ten: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong: ");
            double luong = double.Parse(Console.ReadLine());
            TH_PHAN2_BAI1_Employee employee = new TH_PHAN2_BAI1_Employee(ten, tuoi, luong);
            employee.Show();
            employee.AddSalary();
            employee.Show();
            Console.Write("Nhap ty le: ");
            float tyLe = float.Parse(Console.ReadLine());
            employee.AddSalary(tyLe);
            employee.Show();
        }
    }
}
