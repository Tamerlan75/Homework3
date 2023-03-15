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

Console.WriteLine("Input Size");
int Size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Min");
int Min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Max");
int Max = Convert.ToInt32(Console.ReadLine());

м
ShowArray(RandomArray ( Size, Min, Max));