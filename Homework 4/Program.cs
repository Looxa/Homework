using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк и столбцов матрицы");
            int ColumnOfMarix = Convert.ToInt32(Console.ReadLine());
            int StringOfMatrix = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[StringOfMatrix, ColumnOfMarix];

            for (int o = 0; o < ColumnOfMarix; o++)
            {

                for (int k = 0; k < StringOfMatrix; k++)
                {
                    Console.WriteLine("Заполните элементы массива c координатами X:" + o + "Y:" + k);
                    matrix[o, k] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Сonclusion(matrix); 

            Console.WriteLine("Выберите действие : \nЦифра 1 - Количество полодительных/отрицательных чисел в матрице " +
                "\nЦифра 2 - Сортировка элементов матрицы построчно" +
                " \nЦифра 3 - Инверсия элементов матрицы построчно");
            int SwitchAction = Convert.ToInt32(Console.ReadLine());
            switch (SwitchAction)
            {
                case 1:
                    CountOfPandN(matrix, out int Positive, out int Negative);
                    Console.WriteLine("Положительных: " + Positive + " Отрицательных: " + Negative);
                    break;

                case 2:
                    Sort(matrix, StringOfMatrix, ColumnOfMarix);
                    Сonclusion(matrix);
                    break;

                case 3:
                    Invers(matrix);
                    Сonclusion(matrix);

                    break;

                default:
                    Console.WriteLine("Неверно выбрано действие");
                    break;
            }
            Console.ReadKey();
        }
        static void Сonclusion(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void CountOfPandN(int[,] matrix, out int Positive, out int Negative)
        {
            Positive = 0; Negative = 0;
            foreach (int x in matrix)
            {
                if (x < 0) Negative++;
                else if (x > 0) Positive++;
            }
        }
        static void Sort(int[,] matrix,in int StringOfMatrix,in int ColumnOfMarix)
        {
            for (int i = 0; i < StringOfMatrix; i++)
            {
                for (int j = 0; j < ColumnOfMarix; j++)
                {
                    for (int k = 0; k < ColumnOfMarix; k++)

                    {

                        if (matrix[i, j] < matrix[i, k])
                        {
                            int z = matrix[i, j];
                            matrix[i, j] = matrix[i, k];
                            matrix[i, k] = z;
                        }
                    }
                }

            }
        }
        static void Invers(int[,] matrix)
        {
            int t = 0;
            for (int i = 0; i < matrix.GetLength(1) / 2; i++)
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    t = matrix[j, i];
                    matrix[j, i] = matrix[j, matrix.GetLength(1) - i - 1];
                    matrix[j, matrix.GetLength(1) - i - 1] = t;
                }
        }
    }
}