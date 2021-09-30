using System;

namespace TH_BAITAPTHEM
{
    class Program
    {
        static void Nhap(int[] a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
        static int MaxArr(int[] a, int n)
        {
            int maxArr = a[0];
            for(int i = 1; i < n; i++)
            {
                if(a[i] > maxArr)
                {
                    maxArr = a[i];
                }
            }
            return maxArr;
        }
        static int MinArr(int[] a, int n)
        {
            int minArr = a[0];
            for(int i = 1; i < n; i++)
            {
                if(minArr > a[i])
                {
                    minArr = a[i];
                }
            }
            return minArr;
        }
        static int KiemTraMangDoiXung(int[] a, int n)
        {
            for(int i = 0; i < n /2; i++)
            {
                if(a[i] != a[n - 1 - i])
                {
                    return 0;
                }
            }
            return 1;
        }
        static int DemPhanTu(int[] a, int n, int x)
        {
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                if(a[i] == x)
                {
                    count += 1;
                }
            }
            return count;
        }
        static int TimX(int[] a, int n, int x)
        {
            for(int i = 0; i < n; i++)
            {
                if(a[i] == x)
                {
                    return 1;
                }
            }
            return 0;
        }
        static void Swap(int[] a, int n, int m)
        {
            int temp = a[n];
            a[n] = a[m];
            a[m] = temp;
        }
        static void SapXep(int[] a, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(a[j]< a[i])
                    {
                        Swap(a, i, j);
                    }
                }
            } 
            Xuat(a, n);
        }
        static void ChenX(int []a, int n, int x)
        {
            int position = n - 1;
            while(position >= 0 && a[position] > x)
            {
                a[position + 1] = a[position];
                position = position - 1;
            }
            a[position + 1] = x;
        }
        static void XoaX(int[] a, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    for (int j = i; j < n - 1; j++)
                        a[j] = a[j + 1];
                    n--;
                    i--;
                }
            }
            Xuat(a, n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------Tao mang-------");
            Console.Write("Nhap so luong phan tu mang: ");
            int soLuong = int.Parse(Console.ReadLine());
            int[] array = new int[soLuong];

            Console.WriteLine("-------Nhap mang-------");
            Nhap(array, soLuong);

            Console.WriteLine("-------Xuat mang-------");
            Xuat(array, soLuong);

            Console.WriteLine("-------Tim max-------");
            Console.WriteLine("Max cua mang: " + MaxArr(array, soLuong));

            Console.WriteLine("-------Tim min-------");
            Console.WriteLine("Min cua mang: " + MinArr(array, soLuong));

            Console.WriteLine("-------Kiem tra mang doi xung-------");
            if(KiemTraMangDoiXung(array, soLuong) == 1)
            {
                Console.WriteLine("Mang doi xung");
            }
            else
            {
                Console.WriteLine("Mang khong doi xung");
            }

            Console.WriteLine("-------Dem cac phan tu co gia tri bang x-------");
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("So phan tu trong mang bang {0} la: {1}", x, DemPhanTu(array, soLuong, x));

            Console.WriteLine("------Tim x co trong mang hay khong-------");
            if (TimX(array, soLuong, x) == 1)
            {
                Console.WriteLine("{0} co trong mang", x);
            }
            else{
                Console.WriteLine("{0} khong co trong mang", x);
            }

            Console.WriteLine("------Sap xep mang tang dan-------");
            SapXep(array, soLuong);

            Console.WriteLine("------Xoa x trong man-------");
            XoaX(array, soLuong + 1, x);

            Console.WriteLine("------Chen x vao mang tang-------");
            ChenX(array, soLuong + 1, x);

        }
    }
}
