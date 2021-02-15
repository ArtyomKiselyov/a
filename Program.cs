using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD
{
    class Program
    {
        public static int width;
        public static int height;
        public static int[,] matrix;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину матрицы");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту матрицы");
            height = Convert.ToInt32(Console.ReadLine());
            matrix = new int[width, height];
            Random rand = new Random();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (rand.Next(1, 4) == 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else matrix[i, j] = 0;
                }
            }
            DrawMatrix();
            Console.WriteLine("Введите координату X точки начала");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y точки начала");
            int y = Convert.ToInt32(Console.ReadLine());
            if (matrix[x, y] == 0)
            {
                Fill(x, y);
            }
            DrawMatrix();
        }
        static void DrawMatrix()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[j, i]);
                }
                Console.WriteLine();
            }
            Count();
        }
        static void Fill(int x, int y)
        {
            matrix[x, y] = 2;
            if (x + 1 < width && matrix[x + 1, y] == 0)
            {
                Fill(x + 1, y);
            }
            if (y - 1 >= 0 && matrix[x, y - 1] == 0)
            {
                Fill(x, y - 1);
            }
            if (x - 1 >= 0 && matrix[x - 1, y] == 0)
            {
                Fill(x - 1, y);
            }
            if (y + 1 < height && matrix[x, y + 1] == 0)
            {
                Fill(x, y + 1);
            }
        }
        static void Count()
        {
            int count0 = 0, count1 = 0, count2 = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (matrix[i,j] == 0) count0++;
                    else if (matrix[i, j] == 1) count1++;
                    else if (matrix[i, j] == 2) count2++;
                }
            }
            Console.WriteLine("Нулей: " + count0 + " Единиц: " + count1 + " Двоек: " + count2);
        }
    }
}
