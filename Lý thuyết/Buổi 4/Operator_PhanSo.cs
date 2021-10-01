using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiLop
{
    class PhanSo
    {
		private int tuSo { get; set; }
		private int mauSo { get; set; }
		public PhanSo()
		{
			tuSo = 0;
			mauSo = 1;
		}

		public PhanSo(int tuso, int mauso)
		{
			tuSo = tuso;
			mauSo = mauso;
		}

		public static PhanSo operator +(PhanSo a, PhanSo b)
		{
			PhanSo c = new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);
			return c;
		}

		public static PhanSo operator ++(PhanSo a)
		{
			PhanSo c = new PhanSo(a.tuSo + 1, a.mauSo + 1);
			return c;
		}
		public static PhanSo operator -(PhanSo a, PhanSo b)
		{
			PhanSo c = new PhanSo(a.tuSo * b.mauSo - b.tuSo * a.mauSo, a.mauSo * b.mauSo);
			return c;
		}
		public static PhanSo operator *(PhanSo a, PhanSo b)
		{
			PhanSo c = new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
			return c;
		}
		public static PhanSo operator /(PhanSo a, PhanSo b)
		{
			PhanSo c = new PhanSo(a.tuSo * b.mauSo, b.tuSo * a.mauSo);
			return c;
		}
		public static bool operator !=(PhanSo a, PhanSo b)
		{
			int tu = a.tuSo * b.mauSo - b.tuSo * a.mauSo;
			if (tu != 0)
            {
				return true;
            }
			return false;
		}
		public static bool operator ==(PhanSo a, PhanSo b)
		{
			int tu = a.tuSo * b.mauSo - b.tuSo * a.mauSo;
			if (tu == 0)
            {
				return true;
            }
			return false;
		}
		public static int UCLN(int num1, int num2)
		{
			num1 = Math.Abs(num1);
			num2 = Math.Abs(num2);
			if (num1 == 0 || num2 == 0)
			{
				return num1 + num2;
			}
			else
			{
				while (num1 != num2)
				{
					if (num1 > num2)
					{
						num1 -= num2;
					}
					else
					{
						num2 -= num1;
					}
				}
				return num1;
			}
		}
		public void RutGon()
		{
			int ucln = UCLN(tuSo, mauSo);
			tuSo /= ucln;
			mauSo /= ucln;
		}
		public void Nhap()
		{
			Console.Write("Nhập tử số: ");
			tuSo = int.Parse(Console.ReadLine());
			Console.Write("Nhập mẫu số: ");
			mauSo = int.Parse(Console.ReadLine());
		}

		public override string ToString()
		{
			RutGon();
			if (mauSo == 0)
			{
				return null;
			}
			else if (tuSo == 0 || mauSo == 1)
			{
				return string.Format("{0}", tuSo);
			}
			else
			{
				return string.Format("{0} / {1}", tuSo, mauSo);
			}
		}
	}
}
