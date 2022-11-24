// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int GetSCountNum(int res) 
{
   if(res<0)
   {
    res = - res;
   }
    int count =0;
    
    while(res>0)
    {
        count++;
        res/=10; // так как число res берет от int, то оно считает только целые числа.
    }
    return count;
}


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество цифр "+GetSCountNum(num));