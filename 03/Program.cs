Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int ostatok = number % 2;
if(ostatok == 0)
{
    Console.Write("Вы ввели чётное число.");
}
else
{
    Console.Write("Вы ввели нечётное число.");
}