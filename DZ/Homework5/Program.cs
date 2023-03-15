// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

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

// void Even (int [] arr)

// {
//  int nam = 0;
//  for (int i = 0; i < arr.Length; i++)
//   {  
//      if (arr[i] % 2 == 0) 
//          nam++;
//   }      
// Console.WriteLine($"Number of even numbers: {nam}");
// }

// Console.WriteLine("Input Size");
// int Size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input Min");
// int Min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input Max");
// int Max = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomArray (Size, Min, Max);
// ShowArray (arr);
// Even (arr);


// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

// void Odd (int [] arr)

// {
//  int Sum = 0;
//  for (int i = 0; i < arr.Length; i++)
//   {  
//      if (i % 2 == 1) 
//          Sum+= arr[i];
//   }      
// Console.WriteLine($" Sum of elements in odd positions: {Sum}");
// }

// Console.WriteLine("Input Size");
// int Size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input Min");
// int Min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input Max");
// int Max = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomArray (Size, Min, Max);
// ShowArray (arr);
// Odd (arr);

// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

 int [] RandomArray (int Size, int Min, int Max)
{
    int [] newArr = new int [Size];
    for (int i = 0; i < Size; i++)
        newArr[i] = new Random().Next (Min, Max);
        
    return newArr;
}

void ShowArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write (arr[i] + " ");
}   
Console.WriteLine();

void Difference (int [] arr) 

{
int iMax = 0;
int iMin = 0;
 for (int i = 1; i < arr.Length; i++)
  {  
     if (arr[i] > arr[iMax]) 
      i = iMax;   
    else 
     if (arr [i] < arr[iMin])
      i = iMin; 
  }  
  int diff = arr[iMax] - arr[iMin];    
Console.WriteLine($"difference betveen maximum and minimum: {diff}");
}

Console.WriteLine("Input Size");
int Size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Min");
int Min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Max");
int Max = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomArray (Size, Min, Max);
ShowArray (arr);
Difference (arr);
