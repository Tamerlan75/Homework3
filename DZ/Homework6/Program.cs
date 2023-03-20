
int [] RandomArray (int Size)
{
    int [] newArr = new int [Size];
    for (int i = 0; i < Size; i++)
        Console.WriteLine("Input digits");
        newArr[i] = Convert.ToInt32(Console.ReadLine());
     return newArr;   
}        
    
    
void Even (int [] Arr)
{
 int nam = 0;
 for (int i = 0; i < Arr.Length; i++)
  {  
     if (Arr[i] > 0) 
         nam++;
  }      
Console.WriteLine($"Number of even numbers: {nam}");
}
Console.WriteLine("Input M");
int Size  = Convert.ToInt32(Console.ReadLine());
int[] Arr = RandomArray( Size);
Even(Arr); 