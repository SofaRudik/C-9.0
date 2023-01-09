int rec(int a, int b)
{
    if(a==b)
    return a;
    return rec(a,b-1) + b;
}

Console.Clear();
Console.WriteLine("Введите 1-ое число: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n,m));