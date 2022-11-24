// Создание методов
// алгоритм
// тип переменной , Название, (),{}

// Задача 24: Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

// int GeSumNum()
// {
//     int sum =0;
//     int count =0;

//     while(count<5)
//     {
//         count++;
//         sum +=count; //sum=sumcount
//     }
//     return sum;
// }

int GetSumNum(int res) // важно какой тип переменной помещаем. название любое.
{
    int sum =0;
    int count =0;

    while(count<res)
    {
        count++;
        sum +=count; //sum=sumcount
    }
    return sum;
}

Console.WriteLine(GetSumNum(num)); // важно ввести это, иначе метод пропускает инфу от строк 14 по 24. 
// Можно так же выше вставить - строка 13.
