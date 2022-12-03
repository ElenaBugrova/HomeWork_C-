// Напишите программу, которая на вход принимает два числа
// выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите число a: ");
int a=int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b=int.Parse(Console.ReadLine());
if(a>b)
{
    Console.WriteLine($"a>b, a={a}");
}if(b>a)
{
    Console.WriteLine($"b>a, b={b}");
}if(b==a)
{
    Console.WriteLine("a=b");
}