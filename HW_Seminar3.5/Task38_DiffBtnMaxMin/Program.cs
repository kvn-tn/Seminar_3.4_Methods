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

