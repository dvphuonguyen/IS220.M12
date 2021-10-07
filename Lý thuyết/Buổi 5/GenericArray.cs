using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_QuanLyMangMotChieu
{
    class GenericArray<T>
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
        public GenericArray(){
            soLuong = 0;
            array = new T[soLuong];
        }
        public GenericArray(int size)
        {
            soLuong = size;
            array = new T[soLuong];
        }
        //Nhap mang
        public void NhapMang()
        {
            Console.WriteLine("Nhap so luong phan tu mang:");
            soLuong = int.Parse(Console.ReadLine());
            array = new T[soLuong];
            for(int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("Nhap gia tri cho phan tu thu {0}: ", i);
                array[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
        }
        //Xuat mang
        public void XuatMang()
        {
            Console.WriteLine("Cac phan tu cua mang: ");
            for(int i = 0; i < soLuong; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("\n");
        }
        //Tong cac phan tu trong mang
        public T TongMang()
        {
            dynamic sum = 0;
            for(int  i = 0; i < soLuong; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        //Tim max
        public T MaxArray()
        {
            dynamic maxArray = array[0];
            for(int i = 1; i < soLuong; i++)
            {
                if(maxArray < array[i])
                {
                    maxArray = array[i];
                }
            }
            return maxArray;
        }
        //Tim phan tu co gia tri bang x trong mang
        public int TimX(T x)
        {
           for(int i = 0; i < soLuong; i++)
            {
                if(array[i].Equals(x))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
