// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите кол-во столбцов ");
var columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во строк ");
var rows = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[columns,rows];

for (var i = 0; i < matrix.GetLength(0); i++)
{
    for (var j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-9,9)+ new Random().NextDouble();
        Console.Write(Math.Round(matrix[i,j],1)+" ");
    
        }
    Console.WriteLine();
}