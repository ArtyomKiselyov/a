using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD_2
{
    class Program
    {
        public static int width;
        public static int height;
        public static int[,] matrix;
        public static MyList<int> VectorList = new MyList<int>();
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                VectorList.Add(rand.Next(1, 100));
            }
            VectorList.Write();
            Console.WriteLine(' ');
            Console.WriteLine("RemoveAt, введите индекс");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(' ');
            VectorList.RemoveAt(index);
            VectorList.Write();
            Console.WriteLine(' ');
            Console.WriteLine("Insert, введите индекс и элемент");
            index = Convert.ToInt32(Console.ReadLine());
            int item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(' ');
            VectorList.Insert(index, item);
            VectorList.Write();
            Console.WriteLine("Очистка");
            VectorList.Clear();
            VectorList.Write();
        }
    }
}
