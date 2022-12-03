//  Напишите программу, которая на вход принимает число (N), а на
// выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число N: ");
int N=int.Parse(Console.ReadLine());
if (N>0)
{int B=2;
while (B<=N)
{
    
    Console.Write($"{B} ");
    B=B+2;
}}
else 
{
   int B=0;
    while (B>=N)
{
    
    Console.Write($"{B} ");
    B=B-2;
}}
