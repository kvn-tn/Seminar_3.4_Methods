// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int [] array = {345, 897, 568, 234, 100};
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i]%2 ==0)
    count ++;       
}

 Console.WriteLine("Количество цифр "+count);



// int [] array = {345, 897, 568, 234, 100};
// int [] array2 = new int [array.Length];
// int count = 0;

// int [] GetArray(int[] array2)
// {
// for (int i = 0; i < array.Length; i++)
//     {
//     array2[i]=new Random().Next(100,999);
//     if(array2[i]%2 ==0)
//     count ++;       
//     }
//     return array2;
// }
// GetArray(array2);
// Console.WriteLine(String.Join(" ",array2));

// Console.WriteLine("Количество цифр "+count);