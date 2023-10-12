using System;
using System.Numerics;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("Введите количество строк в вашей матрице");
        var m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов в вашей матрице");
        var n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Введите значение для элемента {i},{j}:");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Далее вы можете выбрать следущие операции для вашей матрицы\n" +
            "1. Количество положительных,отрицательных элементов матрицы\n" +
            "2. Сортировка элементов построчно(в двух направлениях)\n" +
            "3. Инверсия элементов матрицы построчно\n" +
            "4. Выход из программы");
        var operation = Console.ReadLine();
        if (operation == "1")
        {
            Console.WriteLine("Количество каких чисел вы будете считать?\n" +
            "1. Положительных\n" +
            "2. Отрицательных");
            var count = 0;
            var sign = Console.ReadLine();
            if (sign == "1")
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] > 0)
                        {
                            count++;
                        };
                    }
                }
                Console.WriteLine(count);
            }
            else if (sign == "2")
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] < 0)
                        {
                            count++;
                        };
                    }
                }
            }
            Console.ReadLine();
        }
        else if (operation == "2")
        {
            Console.WriteLine("В какое направление вы будете сортировать матрицу\n" +
                "1.Слева направо\n" +
                "2. Справо налево");
            var side = Console.ReadLine();
            if (side == "1")
            {
                for (int i = 0; i < m; i++)
                {
                    // Применяем сортировку пузырьком для текущей строки
                    for (int j = 0; j < n - 1; j++)
                    {
                        for (int k = 0; k < n - j - 1; k++)
                        {
                            if (matrix[i, k] > matrix[i, k + 1])
                            {
                                // Меняем местами элементы
                                int temp = matrix[i, k];
                                matrix[i, k] = matrix[i, k + 1];
                                matrix[i, k + 1] = temp;
                            }
                        }
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            else if (side == "2")
            {
                for (int i = 0; i < m; i++)
                {
                    // Применяем сортировку пузырьком для текущей строки
                    for (int j = 0; j < n - 1; j++)
                    {
                        for (int k = 0; k < n - j - 1; k++)
                        {
                            if (matrix[i, k] < matrix[i, k + 1])
                            {
                                // Меняем местами элементы
                                int temp = matrix[i, k];
                                matrix[i, k] = matrix[i, k + 1];
                                matrix[i, k + 1] = temp;
                            }
                        }
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        else if (operation == "3")
        {
            for (int i = 0; i < m; i++)
            {
                int left = 0;
                int right = n - 1;

                while (left < right)
                {
                    // Меняем местами элементы
                    int temp = matrix[i, left];
                    matrix[i, left] = matrix[i, right];
                    matrix[i, right] = temp;

                    left++;
                    right--;
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.ReadLine();
        }
    }
}