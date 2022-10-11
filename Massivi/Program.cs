// Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B.
// Заполнить одномерный массив A числами, введенными с клавиатуры пользователем, а двумерный массив B случайными числами с помощью циклов.
// Вывести на экран значения массивов: массива A в одну строку, массива B - в виде матрицы.
// Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее произведение всех элементов,
// сумму четных элементов массива A, сумму нечетных столбцов массива B.

using System;
using System.Data;
using System.Globalization;

double[] A = new double[5];             // Объявить одномерный (5 элементов) массив с именем A

for (int i = 0; i < 5; i++)             // Заполнить одномерный массив A числами, введенными с клавиатуры пользователем
{
    Console.Write($"Введите {i+1} элемент массива: ");
    A[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < 5; i++)            // Вывести на экран значения массива A в одну строку
{
    Console.Write(Math.Round(A[i], 3)); 
    Console.Write("\t");
}

Console.WriteLine();
Console.WriteLine();

double[,] B = new double[3, 4];         // Объявить двумерный массив (3 строки, 4 столбца) дробных чисел с именем B.
Random random = new Random();

for (int i = 0; i < 3; i++)             // Заполнить двумерный массив B случайными числами с помощью циклов.
{
    for (int j = 0; j < 4; j++)
    {
        B[i, j] = random.NextDouble();
    }
}

Console.WriteLine();

for (int i = 0; i < 3; i++)             // Вывести на экран значения массива B в виде матрицы
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(Math.Round(B[i, j], 3));
        Console.Write("\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();

// Найти в данных массивах общий максимальный элемент

double maxA = A.Max();
Console.WriteLine("Максимальный элемент массива A : " + Math.Round(maxA, 3));
Console.WriteLine();
double maxB = B.Cast<double>().Max();
Console.WriteLine("Максимальный элемент массива B : " + Math.Round(maxB, 3));
Console.WriteLine();
if (maxA == maxB) Console.WriteLine("Общий максимальный элемент массивов : " + Math.Round(maxA, 3));
else Console.WriteLine("Общего максимального элемента в массивах нет");
Console.WriteLine();
Console.WriteLine();

// Найти в данных массивах общий минимальный элемент

double minA = A.Min();
Console.WriteLine("Минимальный элемент массива A : " + Math.Round(minA, 3));
Console.WriteLine();
double minB = B.Cast<double>().Min();
Console.WriteLine("Минимальный элемент массива B : " + Math.Round(minB, 3));
Console.WriteLine();
if (minA == minB) Console.WriteLine("Общий минимальный элемент массивов : " + Math.Round(minA, 3));
else Console.WriteLine("Общего минимального элемента в массивах нет");
Console.WriteLine();
Console.WriteLine();

// Найти в данных массивах общую сумму всех элементов

double sumA = A.Sum();
Console.WriteLine("Общая сумма всех элементов массива A : " + Math.Round(sumA, 3));
Console.WriteLine();
double sumB = B.Cast<double>().Sum();
Console.WriteLine("Общая сумма всех элементов массива B : " + Math.Round(sumB, 3));
Console.WriteLine();
if (sumA == sumB) Console.WriteLine("Общая сумма всех элементов массивов : " + Math.Round(sumA, 3));
else Console.WriteLine("Общей суммы всех элементов массивов нет");
Console.WriteLine();
Console.WriteLine();

// Найти в данных массивах общее произведение всех элементов

double multA = A[0];
for (int j = 1; j < 5; j++)
{
    multA = multA * A[j];
}
Console.WriteLine("Общее произведение всех элементов массива A : " + Math.Round(multA, 3));
Console.WriteLine();

double multB = B[0,0];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        multB = multB * B[i,j];
    }
}
Console.WriteLine("Общее произведение всех элементов массива B : " + Math.Round(multB, 3));
Console.WriteLine();

if (multA == multB) Console.WriteLine("Общее произведение всех элементов массивов : " + Math.Round(multA, 3));
else Console.WriteLine("Общего произведение всех элементов массивов нет");
Console.WriteLine();
Console.WriteLine();

// Найти сумму четных элементов массива A

double sum_A = 0;
for (int j = 0; j < 5;)
{
    sum_A = sum_A + A[j];
    j = j + 2;
}
Console.WriteLine("Сумма четных элементов массива A : " + Math.Round(sum_A, 3));
Console.WriteLine();

// Найти сумму нечетных столбцов массива B

double sum_B = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 1; j < 4;)
    {
        sum_B = sum_B + B[i, j];
        j = j + 2;
    }
}
Console.WriteLine("Сумма нечетных столбцов массива B : " + Math.Round(sum_B, 3));
Console.WriteLine();

Console.ReadKey();







