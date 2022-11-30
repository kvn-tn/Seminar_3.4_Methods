// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// //Console.Write("Введите несколько чисел от -10 до 10: ");
// //int num = Convert.ToInt32(Console.ReadLine()); // - как написать?

// int []array = {0, 7, 8, -2, -2};
// int []array = new int [10];

// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]= new Random().Next(-100,1000);
    
//      if(array[i]>0)
//     {
//         sum++;       
//     }
// }
// Console.WriteLine(String.Join(" ",array));
// Console.WriteLine("Количество цифр "+sum);

Console.Write("Сколько чисел вы хотите ввести? ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа по одному: ");
int[] array = new int [numb];

int PositiveCount(int count)
{
    int countOfPositive = 0;
    for(int i = 0; i < count;i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            countOfPositive+=1;
        }
        Console.WriteLine(string.Join(",", array));
        Console.Write("Введите числа по одному: ");
    }
    return countOfPositive;
}
int posCount = PositiveCount(numb);
Console.Write($"количество положительных чисел = {posCount}");