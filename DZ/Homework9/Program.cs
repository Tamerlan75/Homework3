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

// int SumDigit (int m, int n)
// {
    
//     if (m < n)
//     {
//         return m + SumDigit(m+1, n);
//     }
//     else
//         return n;   
// }

// Console.WriteLine(SumDigit ( 1, 15));

// // Console.WriteLine("Введите m");//
// // int m = Convert.ToInt32(Console.ReadLine());// 
// // Console.WriteLine("Введите n");//
// // int n = Convert.ToInt32(Console.ReadLine());//
// // Console.WriteLine($"M = {m}; N = {n} -> {SumDigit ( m, n)}");//


//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



// int akker(int m, int n)
// {
// if (m == 0) return n + 1;
// else if (n == 0) return akker(m - 1, 1);
// else return akker(m - 1, akker(m, n - 1));
// }
// Console.WriteLine("Введите значение M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение N");
// int n = Convert.ToInt32(Console.ReadLine());


// Console.Write($"m={m}, n={n} -> A(m,n) = {akker(m, n)} ");
