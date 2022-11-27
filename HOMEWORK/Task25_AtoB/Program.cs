// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine (Math.Pow(numA, numB));

int GetSumNum(int numA, int numB)
{
int result = 1; 

for (int i = 0; i < numB; i++) 
 {
 result *= numA; 
 }
return result;
}

int res = GetSumNum(A, B);
Console.WriteLine(res);

