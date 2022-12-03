// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[new Random().Next(7, 7), new Random().Next(7, 7)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 11);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("_________________");

int sum = 0;
int minSum = Int32.MaxValue;
int minRow = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        minRow = i;
    }
    sum = 0;
}

Console.WriteLine("Строка с наименьшей суммой элементов - " + minRow);

