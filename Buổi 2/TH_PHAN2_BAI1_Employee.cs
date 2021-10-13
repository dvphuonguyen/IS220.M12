using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_PHAN2_BAI2
{
    class TH_PHAN2_BAI1_Employee:TH_PHAN2_BAI1_Person
    {
        private double salary;
        public double Salary { get => salary; set => salary = value; }
        public TH_PHAN2_BAI1_Employee()
        {
            salary = 0;
        }
        public TH_PHAN2_BAI1_Employee(double luong)
        {
            salary = luong;
        }
        public TH_PHAN2_BAI1_Employee(string ten, int tuoi, double luong):base(ten, tuoi)
        {
            salary = luong;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("\tLuong: {0}", salary);
        }
        public void AddSalary()
        {
            salary *= 1.1;
        }
        public void AddSalary(float tyLe)
        {
            salary *= (1 + tyLe);
        }
    }
}
