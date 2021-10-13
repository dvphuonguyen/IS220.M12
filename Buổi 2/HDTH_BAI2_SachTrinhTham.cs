using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDTH_BAI2
{
    class HDTH_BAI2_SachTrinhTham:HDTH_BAI2_Sach
    {
        private float thue;
        public float Thue
        {
            get => thue;
            set { thue = value; }
        }
        public HDTH_BAI2_SachTrinhTham() 
        {
            thue = 0;
        }
        public HDTH_BAI2_SachTrinhTham(float tax)
        {
            thue = tax;
        }
        public HDTH_BAI2_SachTrinhTham(long id, string name, double price, int size, string publish, float tax) : base(id, name, price, size, publish)
        {
            thue = tax;
        }
        public override void ToString()
        {
            base.ToString();
            Console.Write("\n\tTien thue: " + thue);

        }
        public override double ThanhTien()
        {
            return base.ThanhTien() + thue;
        }
    }
}
