// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [7];

int NumSum = 0;

int [] GetArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(-10,100);
        if(i%2 ==1)
        {
            NumSum = NumSum + array[i];
        } 
    }
    return array;
}
GetArray(array);
Console.WriteLine(String.Join(" ",array));
Console.WriteLine(NumSum);

// int [] array = {3, 7, 23, 12};
// int [] array2 = new int [array.Length];

// int NumSum = 0;

// int [] GetArray(int[] array2)
// {
// for (int i = 1; i < array.Length; i+=2)
//     {
//         array2[i]=new Random().Next(-10,100);
//         NumSum = NumSum + array2[i];
//     }
//     return array2;
// }
// GetArray(array2);
// Console.WriteLine(String.Join(" ",array2));
// Console.WriteLine(NumSum);