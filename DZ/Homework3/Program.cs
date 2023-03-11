void Polyan(int P)
{
int nam1 = P/10000;
int nam2 = P/1000;
nam2 = nam2%10;
int nam4 = P/10; 
nam4 = nam4%10;
int nam5 = P%10;
if (nam1=nam4) 
 if(nam2=nam5)
  Console.WriteLine($"{P} -> Да");
else
   Console.WriteLine($"{P} -> Нет"); 
}   
Console.WriteLine("Input five-digit number");
int P = Convert.ToInt32(Console.ReadLine());
Polyan(P);

