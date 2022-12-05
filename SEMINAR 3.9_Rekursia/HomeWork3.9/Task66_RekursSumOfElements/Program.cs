﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первоначальное число промежутка M: ");
int m =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число промежутка N: ");
int n =Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNum(m,n));

int SumNum(int m, int n)
{
    int start = m;
    int end = n;
    if (start>end)
    {
        start=n; 
        end=m;
    }
    if (start==end)
    {
        return end;
    }
    return(start+end)*(end-start+1)/2;
}
