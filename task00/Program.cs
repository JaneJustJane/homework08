// Показать натуральные числа от M до N, N и M заданы


Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

void Numbers (int n, int m)
{
    if (m<=n)
    {
        Console.Write(m + " ");
        m++;
        Numbers (n,m);
   
    }
}  

Numbers(n,m);