// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 // делим на 2 и остатки в обратном порядке записываем
// 3  -> 11
// 2  -> 10

// string result = ""; //-  пустой символ


Console.Write(" N =  ");
int n = Convert.ToInt32(Console.ReadLine());

string result ="";
while(n>0)
{
    result=n%2+result;

    n/=2;

}
Console.Write(result);