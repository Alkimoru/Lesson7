Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int b = Convert.ToInt32(Console.ReadLine());
void PrintNumbersA(int a)
{
    if (a < b - 1)
    {
        a++;
        Console.Write($"{a}, ");
        PrintNumbersA(a);
    }
}
void PrintNumbersB(int b)
{
    if (b < a - 1)
    {
        b++;
        Console.Write($"{b}, ");
        PrintNumbersB(b);
    }
}
if (a < b)
{
    PrintNumbersA(a);
}
else
{
    PrintNumbersB(b);
}