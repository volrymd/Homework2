//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите порядковый номер дня недели: ");
int n = int.Parse(Console.ReadLine()!);

while (n<1 || n>7)
{
    Console.Write("Вы ошиблись!\nВведите порядковый номер дня недели: ");
    n = int.Parse(Console.ReadLine()!);
}

if (n == 6 || n == 7)
    Console.WriteLine("Да, это выходной!");
else
    Console.WriteLine("Нет, это будний день!");

