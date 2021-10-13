using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_PHAN2_BAI3
{
    class TH_PHAN2_BAI3_GenericArray<T>
    {
        private int soLuong;
        private T[] array;
        // khoi tao so phan tu mang + cap phat cho mang
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public T[] Array { get => array; set => array = value; }
        public T Get(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            return default(T);
        }
        public void Set(int index, T value)
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = value;
            }
        }
        public TH_PHAN2_BAI3_GenericArray()
        {
            soLuong = 0;
            array = new T[soLuong];
        }
        public TH_PHAN2_BAI3_GenericArray(int size)
        {
            soLuong = size;
            array = new T[soLuong];
        }
        public void NhapMang()
        {
            Console.WriteLine("Nhap so luong phan tu mang:");
            soLuong = int.Parse(Console.ReadLine());
            array = new T[soLuong];
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("Nhap gia tri cho phan tu thu {0}: ", i);
                array[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
        }
        public void XuatMang()
        {
            Console.WriteLine("Cac phan tu cua mang: ");
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("\n");
        }
        public T MaxArray()
        {
            dynamic maxArray = array[0];
            for (int i = 1; i < soLuong; i++)
            {
                if (maxArray < array[i])
                {
                    maxArray = array[i];
                }
            }
            return maxArray;
        }

        public T MinArray()
        {
            dynamic minArray = array[0];
            for (int i = 1; i < soLuong; i++)
            {
                if (minArray > array[i])
                {
                    minArray = array[i];
                }
            }
            return minArray;
        }
    }
}
