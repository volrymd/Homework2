﻿// Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
// Входные данные
// Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.
// Выходные данные
// В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума.

Console.Clear();
Console.Write("Введите сколько будет чисел в последовательности (не больше 100): ");
int n = int.Parse(Console.ReadLine()!);

while (n<1 || n>100)
{
    Console.Write("Вы ошиблись\nВведите сколько будет чисел в последовательности (не больше 100): ");
    n = int.Parse(Console.ReadLine()!);
}

Console.Write("Укажите, на какой позиции будет 0 (не раньше 3 числа): ");
int m = int.Parse(Console.ReadLine()!);

while (m<3 || m>n)
{
    Console.Write("Вы ошиблись\nУкажите, на какой позиции будет 0 (не раньше 3 числа): ");
    m = int.Parse(Console.ReadLine()!);
}

int i = 0;
int max1 = 0;
int max2 = 0;
int numberB = 0;
do 
{
    int numberA = new Random().Next (0,100);
    Console.WriteLine (numberA);
    if (numberA>max1) 
    {
        max2 = max1; 
        max1 = numberA;
    }
    else if (numberA>max2) 
    {
        max2 = numberA;
        } 
    i++;
    if (i == m-1) 
       {Console.WriteLine (numberB);}
    }
    while (i<n-1);

Console.Write ("Максимальное число ");
Console.WriteLine (max1);

Console.Write ("Второе максимальное число ");
Console.WriteLine (max2);
