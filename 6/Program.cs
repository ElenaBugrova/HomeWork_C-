//  Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число a: ");
int a=int.Parse(Console.ReadLine());
int y=a%2;
if(y==0)
{
    Console.WriteLine($"Число {a} четное");
}else{
Console.WriteLine($"Число {a} нечетное");
}