using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] mas = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                mas[i] = rand.Next(0, 30);
                Console.Write(mas[i] + "\t");
            }
            Console.Write("\nОтсортированный массив \n");
            quick_sort(mas, 0, size - 1);

            for (int i = 0; i < size; i++)
            {
                Console.Write(mas[i] + "\t");
            }
        }
        static void quick_sort(int[] mas, int firstArg, int lastArg)
        {
            int i = firstArg, j = lastArg;
            int indCentr = (firstArg + lastArg) / 2;
            int centerNum = mas[indCentr];
            int temp = 0;
            do
            {
                while (mas[i] < centerNum) i++;
                while (centerNum < mas[j]) j--;
                if (i <= j)
                {
                    temp = mas[i];
                    mas[i] = mas[j];
                    mas[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (firstArg < j)
                quick_sort(mas, firstArg, j);
            if (i < lastArg)
                quick_sort(mas, i, lastArg);
        }
    }
}
