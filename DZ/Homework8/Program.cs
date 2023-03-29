int[,] Create2DRandomArray (int rows, int columns, int Min, int Max)
{
    int[,] myArray = new int[rows,columns];

    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
         myArray [i,j] = new Random().Next(Min, Max);
       }  
    }
    return myArray;
}  

void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int j = 0; j < array.GetLength (1); j++)
        {
            Console.Write (array [i, j] + " ");
        }
     Console.WriteLine ();     
    } 
Console.WriteLine ();    
}

int MinSum (int [,] array)
{
    int Sum = 0;
    for (int i=0; i < array.GetLength(0); i++)
    {
       int MinSum = Sum; 
       Sum = 0;
     for (int j=0; j < array.GetLength(1); j++)
     {
        Sum += array[i,j];
        if (Sum < MinSum)
        int MinI = i+1;
       
     }
    } 
return MinI; 

}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите Min ");
int Min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Max");
int Max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray (rows, columns, Min, Max);
Show2DArray (myArray);
MinSum (myArray);
Console.WriteLine($"Строка с наименьшей суммой-> {MinI}");