// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < arr.GetLength(1); k++)
                {
                    if (arr[i, j] < arr[i, k])
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка
class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

        int minSum = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minIndex = i;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов: {0}", minIndex + 1);
    }
}

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
class Program
{
    static void Main(string[] args)
    {
        int[,] matras1 = new int[,] { { 2, 4 }, { 3, 2 } };
        int[,] matras2 = new int[,] { { 3, 4 }, { 3, 3 } };

        int[,] result = new int[matras1.GetLength(0), matras2.GetLength(1)];

        for (int i = 0; i < matras1.GetLength(0); i++)
        {
            for (int j = 0; j < matras2.GetLength(1); j++)
            {
                for (int k = 0; k < matras1.GetLength(1); k++)
                {
                    result[i, j] += matras1[i, k] * matras2[k, j];
                }
            }
        }

        Console.WriteLine("Финальный матрас:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
class Program
{
    static void Main(string[] args)
    {
        int[,,] arr = new int[2, 2, 2];
        int num = 10;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    arr[i, j, k] = num;
                    num++;
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ") ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}


// 64. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Числа от N до 1: ");
        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        Console.Write(n);
        if (n > 1)
        {
            Console.Write(", ");
            PrintNumbers(n - 1);
        }
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Сумма чисел от {m} до {n}: {sum}");
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

class Program
{
    static int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        int m = 2, n = 3;
        Console.WriteLine("A({0}, {1}) = {2}", m, n, Akkerman(m, n));

        m = 3; n = 2;
        Console.WriteLine("A({0}, {1}) = {2}", m, n, Akkerman(m, n));
    }
}
