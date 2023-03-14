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

int Sum (int nam)
{
    int Sum = 0;
    while (nam > 0)    
        Sum = Sum + nam % 10 ;
        nam = nam / 10;
    return Sum;
}
Console.WriteLine("Input nam");
int nam = Convert.ToInt32(Console.ReadLine());
int res = Sum(nam);
Console.WriteLine($"{nam} -> {res}");

