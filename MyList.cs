using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD_2
{
    class MyList<T>
    {
        private T[] list;
        private int count;
        const int n = 10;
        private T v;
        public MyList()
        {
            list = new T[n];
        }
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public int Count
        {
            get { return count; }
        }
        public void Add(T item)
        {
            if (count == list.Length)
                Array.Resize(ref list, count + 1);
            list[count++] = item;
        }
        public T Last()
        {
            return list[count - 1];
        }
        public T First()
        {
            return list[0];
        }
        public void Clear()
        {
            Array.Resize(ref list, count - count);
            count = 0;
        }
        public void Insert(int index, T item)
        {
            T temp = list[0];
            Array.Resize(ref list, count + 1);
            list[count] = list[0];
            for (int i = index; i < count; i++)
            {
                temp = list[i + 1];
                list[i + 1] = list[index];
                list[index] = temp;
            }
            count++;
            list[index] = item;
        }
        public void RemoveAt(int index)
        {
            T temp = list[0];

            for (int i = count; i > index; i--)
            {
                temp = list[i - 1];
                list[i - 1] = list[index];
                list[index] = temp;
            }
            Array.Resize(ref list, list.Length - 1);
            count--;
        }
        public void Write()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public T this[int index]
        {
            get { return v; }
            set { v = list[index]; }
        }
        public IEnumerator<T> GetEnumerator()
        {
            yield return (T)list.GetEnumerator();
        }
        public int IndexOf(T item)
        {
            return 0;
        }
    }
}
