// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Clear();
Console.WriteLine("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

EvenNaturalNumber(m, n);

void EvenNaturalNumber (int m, int n)
{
    if ( m % 2 == 0 ) 
        Console.Write($"{m} ");
    
    if ( n > m )
        EvenNaturalNumber( m + 1, n );

    else if ( m > n ) 
        EvenNaturalNumber( m - 1, n );

    else Console.WriteLine();
    
}
  