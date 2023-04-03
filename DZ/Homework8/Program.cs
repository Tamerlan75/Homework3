// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

// int[] SumRows (int [,] array)
// {
// int[] arraySum = new int[array.GetLength(0)];
    
//     for (int i=0; i < array.GetLength(0); i++)
//     {
        
//         int Sum = 0;
//      for (int j=0; j < array.GetLength(1); j++)
//      {
//         arraySum[i] =  Sum + array[i,j];                                
//      }
//     } 
// return arraySum; 
// }

// void MinSumRows (int[] array)
// {
//     int MinSum = array[0];
//     int minI = 1;
// for (int i = 1; i < array.GetLength(0); i++)
//   {
//     if (array[i] < MinSum)
//     array[i] = MinSum;
//     minI = i+1;
//   }
// Console.WriteLine($"Строка с наименьшей суммой-> { minI}");
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
// SumRows (myArray);
// int[] ArraySum = SumRows ( myArray);
// MinSumRows (ArraySum); 

 
 //Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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
// int[,] DescendingArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
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
// DescendingArray(myArray);
// myArray = DescendingArray(myArray);
// Show2DArray (myArray);


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// int[,,] Create3DRandomArray (int rows, int columns, int lines, int Min, int Max)
// {
//     int[,,] myArray = new int[rows,columns, lines];

//     for (int i = 0; i < rows; i++)
//     {
//        for (int j = 0; j < columns; j++)
//        {   
//         for (int z = 0; z < lines; z++)
//         {
//          myArray [i,j,z] = new Random().Next(Min, Max);
//         } 
//        }

//     }
//     return myArray;
// }  

// void Show3DArray (int[,,] array)
// {
//     for (int i = 0; i < array.GetLength (0); i++)
//     {
//         for (int j = 0; j < array.GetLength (1); j++)
//         {
//           for (int z = 0; j < array.GetLength (2); z++)  
//           {
//             Console.Write ($"{array [i, j, z]}  ({i} {j} {z}) ");
//           }
//          Console.WriteLine (); 
//         }
//         Console.WriteLine ();     
//     } 
//     Console.WriteLine (); 

// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество рядов");
// int lines = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ведите Min ");
// int Min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Max");
// int Max = Convert.ToInt32(Console.ReadLine());
// int[,,] myArray = Create3DRandomArray (rows, columns, lines,  Min, Max);
// Show3DArray (myArray);
