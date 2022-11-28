// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] array = {3, 7, 22, 2, 78, 123, .6};
// double MaxNum = array[0];
// double MinNum = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]>MaxNum)
//     {
//         MaxNum = array[i];
//     }
//       if (array[i]<MinNum)
//     {
//         MinNum = array[i]; 
//     }
// }

// Console.WriteLine(("Максимальное значение = "+MaxNum)+" "+("Mинимальное значение = "+MinNum));
// Console.WriteLine("Разница = "+(MaxNum - MinNum));

int[] array = new int[8];
int MaxNum = int.MinValue; // функция считает переменные как положительные так и отрицательные. 
// Сама переменная самая большая, все остальные будут меньше.
int MinNum = int.MaxValue;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    if (array[i] > MaxNum)
    {
        MaxNum = array[i];
    }
    if (array[i] < MinNum)
    {
        MinNum = array[i];
    }
}

Console.WriteLine(("Максимальное значение = " + MaxNum) + " " + ("Mинимальное значение = " + MinNum));
Console.WriteLine("Разница = " + (MaxNum - MinNum));

// Console.Clear();
// Console.WriteLine("Введите желаемое кол-во элементов массива N ");
// Console.Write(" N =  ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[] num = SetArrayRealNumbers(n);

// double min = num[0];
// double max = num[0];

// for (int i = 0; i < n; i++)
// {
//     if (num[i] >= max)
//     {
//         max = num[i];
//     }
//     else if (num[i] <= min)
//     {
//         min = num[i];
//     }
// }

// Console.Write(String.Join("; ", num));

// Console.WriteLine();

// Console.WriteLine($" В данном массиве разница между максимальным ({max}) и минимальным ({min})\n 
//элементом с учетом знака будет равна max - min  = {Math.Round((max - min), 2)}");

//  double[] SetArrayRealNumbers (int n)
// {
//     double[] num = new double[n];

//     for (int i = 0; i < n; i++)
//     {
//         num[i] = new Random().Next(100, 1000) + new Random().NextDouble(); // все числа после запятой указаны 
//во второй части (после плюса)

//         num[i] = Math.Round(num[i], 2); // функция указывает сколько элементов отсечь после запятой
//     }
//     return num;
// }