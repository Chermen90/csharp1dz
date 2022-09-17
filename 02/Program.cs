Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());
int max = 0;

if(a > b)
{
    if(a > c)
    {
        max = a;
    }
    else if(a < c)
    {
        max = c;
    }
    
}

else if(a < b)
{
    if(b > c)
    {
        max = b;
    }
    else if(b < c)
    {
        max = c;
    }
}

Console.Write($"max = {max}");
