﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.Write("Введите кол-во столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите кол-во строк ");
// int rows = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] =new Random().Next(0,99);
//         Console.Write(matrix[i,j]+" "); 
//     }
//         Console.WriteLine();
// }
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 int sum =0;
//                 int average =0;
//                 for (int i = 0; i < matrix.GetLength(0); i++)
//                     {
//                         sum += matrix[i,j];
//                         average = sum / matrix.GetLength(0);
                    
//                     }
//                    Console.WriteLine("Среднее арифметическое столбца "+j+ " равно = "+ average);                    
//             }
//         }
    
Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] =new Random().Next(0,99);
        Console.Write(matrix[i,j]+" "); 
    }
        Console.WriteLine();
}
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                double sum =0;
                double average =0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        sum += matrix[i,j];
                        average = sum / matrix.GetLength(0);
                    
                    }
                   Console.WriteLine("Среднее арифметическое столбца "+j+ " равно = "+ average);                    
            }
        }