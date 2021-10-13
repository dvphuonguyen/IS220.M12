using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_PHAN2_BAI2
{
    class TH_PHAN2_BAI1_Person
    {
        private string name;
        private int age;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public TH_PHAN2_BAI1_Person()
        {
            name = null;
            age = 0;
        }
        public TH_PHAN2_BAI1_Person(string ten, int tuoi)
        {
            name = ten;
            age = tuoi;
        }
        public virtual void Show()
        {
            Console.WriteLine("Thong tin nguoi:\n\tTen: {0}\n\tTuoi:{1}", name, age);
        }
    }
}
