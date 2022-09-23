// SЗадача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

Console.Clear();
Console.WriteLine("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

GreatestCommonDivisor(m, n);

void GreatestCommonDivisor(int m, int n)
{
    if( n % m == 0 ) 
    Console.Write($"Наибольший общий делитель равен - {m}");

    else 
    GreatestCommonDivisor(n - ( n / m ) * m, m);
}