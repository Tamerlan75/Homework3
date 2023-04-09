// Задайте значение N. Напишите программу, которая выведет все натуральные числа в
//  промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void Digit (int N)
// {
// if (N >=1)
// {
//     Console.Write(N + " ");
//     Digit ((N-1));
// }
// }

// Digit(8);

//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumDigit (int m, int n)
{
    
    if (m <= n)
    {
        return m + SumDigit(m+1, n);
    }
    else
        return n;
    
   
}
Console.WriteLine($"M = {m}; N = {n} -> {SumDigit ( m, n)}");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

// SumDigit ( 1, 15);