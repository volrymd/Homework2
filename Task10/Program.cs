// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);

while (n<100 || n>999)
{
    Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
    n = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(n /10 % 10);
