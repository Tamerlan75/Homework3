// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Pow (int A, int B)
// {
//     int P = A;
//     for (int i = 0; i < B-1; i++)
//     P = P * A;
//     return P;
// }

// Console.WriteLine("Input A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ($"A^B -> {Pow(A, B)}");
// Pow(A, B);


// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum (int nam)
// {
//     int Sum = 0;
//     while (nam > 0) 
//     {
//         int i = 1;
//         Sum += nam % 10;
//         nam /= 10;
//         i ++;
//     }   
        
//     return Sum;
// }
// Console.WriteLine("Input nam");
// int nam = Convert.ToInt32(Console.ReadLine());
// Sum(nam);
// int ans = Sum(nam);
// Console.WriteLine($"{nam} -> {ans}");


// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] RandomArray (int Size, int Min, int Max)
// {
//     int [] newArr = new int [Size];
//     for (int i = 0; i < Size; i++)
//         newArr[i] = new Random().Next (Min, Max);
        
//     return newArr;
// }
// void ShowArray (int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.Write (arr[i] + " ");
// }   
// Console.WriteLine();

// Console.WriteLine("Input Size");
// int Size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input Min");
// int Min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input Max");
// int Max = Convert.ToInt32(Console.ReadLine());

// ShowArray(RandomArray ( Size, Min, Max));
// // -(ShowArray (RandomArray (8, 1, 10));)-