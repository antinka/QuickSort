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
            quickSort(mas, 0, size - 1);

            for (int i = 0; i < size; i++)
            {
                Console.Write(mas[i] + "\t");
            }
        }
        static void quickSort(int[] mas, int firstArg, int lastArg)
        {
            int stepForward = firstArg;
            int stepBack = lastArg;
            int indCentr = (firstArg + lastArg) / 2;
            int centerNum = mas[indCentr];
            int temp = 0;
            do
            {
                while (mas[stepForward] < centerNum)
                {
                    stepForward++;
                }
                while (centerNum < mas[stepBack])
                {
                    stepBack--;
                }
                if (stepForward <= stepBack)
                {
                    temp = mas[stepForward];
                    mas[stepForward] = mas[stepBack];
                    mas[stepBack] = temp;
                    stepForward++;
                    stepBack--;
                }
            } while (stepForward <= stepBack);

            if (firstArg < stepBack)
            { 
                quickSort(mas, firstArg, stepBack);
            }
            if (stepForward < lastArg)
            {
                quickSort(mas, stepForward, lastArg);
            }
        }
    }
}
