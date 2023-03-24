// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] Create2DRandomArray (int rows, int columns, int Min, int Max)
// {
//     double [,] newArr = new double [rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//       for (int j = 0; j < columns; j++)  
//       {
//         newArr[i, j] = Math.Round(new Random().Next (Min, Max) + new Random().NextDouble (), 2);
//       }

//      }    
//     return newArr;
// }

// void Show2DArray (double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write (array[i, j] + " ");
//         }
    
//         Console.WriteLine ();
//     }    
// }   
// Console.WriteLine();

// Console.Write("Введите количество строк ");
//  int rows = Convert.ToInt32(Console.ReadLine()); 
//  Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите минимальное значение ");
// int Min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение "); 
// int Max = Convert.ToInt32(Console.ReadLine()); 
// double[,] array = Create2DRandomArray (rows, columns, Min, Max);
// Show2DArray (array);

 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue) 
// { 

//      int[,] myArray = new int[rows, columns];     
//      for(int i = 0; i < rows;i++)     
//    {         
//         for(int j = 0; j < columns;j++)         
//     {             
//         myArray[i,j] = new Random().Next(minValue, maxValue + 1);         
//     }     
//    }     
// return myArray;
// }  

// void Show2DArray (int[,] array) 
// {     

//    for(int i = 0; i < array.GetLength(0);i++)    
//    {         
//        for(int j = 0; j < array.GetLength(1);j++)        
//     {             
//         Console.Write(array[i,j] + " ");         
//     }  

//     Console.WriteLine();     

//    }    
//      Console.WriteLine(); 
// }

// void Element (int[,] array,  int N,int M) 

// {  
//        for(int i = 0; i < array.GetLength(0);i++)    
//    {         
//        for(int j = 0; j < array.GetLength(1);j++)  
//        { 
//         if ( i == N && j == M)
          
//           Console.WriteLine($" Элемент массива с координатами {N},{M}-> {array [i, j]}");    
//        } 
//    }
   
   
// } 
// Console.Write("Введите N "); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите M "); 
// int M = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите количество строк "); 
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите количество столбцов "); 
// int columns = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите минимальное значение "); 
// int minValue = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите максимальное значение "); 
// int maxValue = Convert.ToInt32(Console.ReadLine());  

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);  
// Show2DArray(myArray); 
// Element(myArray, N, M); 
// if (N >=rows || M >= columns) 
// Console.WriteLine($"{N}, {M}, Элемента с такой позицией нет");


//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
//столбце.

// int[,] Create2DRandomArray (int rows, int columns, int Min, int Max)
// {
//     int[,] myArray = new int[rows,columns];

//     for (int i = 0; i < rows; i++)
//     {
//        for (int j = 0; j < columns; j++)
//        {
//          myArray [i,j] = new Random().Next(Min, Max);
//        }  
//     }
//     return myArray;
// }  

// void Show2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength (0); i++)
//     {
//         for (int j = 0; j < array.GetLength (1); j++)
//         {
//             Console.Write (array [i, j] + " ");
//         }
//      Console.WriteLine ();     
//     } 
// Console.WriteLine ();    
// }

// void Average (int[,] array)
// {
//     int Sum =0;
//     Double Aver = 0;
//     Console.Write("Среднее арифметическое столбца ->" +  " ");
//     for (int j = 0; j < array.GetLength (1); j++)
//     {
//         for (int i = 0; i < array.GetLength (0); i++)
//         {
//             Sum += array [i, j];          
//         }
//     Aver = Sum / array.GetLength (0);  
//     Console.Write ( Aver + " ");
//     Sum = 0;    
//     }
// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите Min ");
// int Min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Max");
// int Max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray (rows, columns, Min, Max);
// Show2DArray (myArray);
// Average (myArray);