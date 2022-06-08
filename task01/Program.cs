// Найти сумму элементов от M до N, N и M заданы

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int result = 0;

void Sum (int n, int m)
{
    if (m<=n)
    {
        result = result + m;
        m++;
        Sum (n,m);
    }
}  
Sum (n,m);
Console.WriteLine($"Cумма чисел от {m} до {n} = {result}");