// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Clear();
Console.WriteLine("Введите число M (больше нуля): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N (больше нуля): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна : ");
SumNaturalNumbers (m,n, 0);

void SumNaturalNumbers(int m, int n, int sum)
{
    if( m > 0 ) sum += m;

    if ( n > m ) 
        SumNaturalNumbers( m + 1, n, sum );

    else if( m > n ) 
        SumNaturalNumbers( m - 1, n, sum );

    else Console.WriteLine(sum);
}