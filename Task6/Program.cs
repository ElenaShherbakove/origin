﻿// напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка)
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)  
{
Console.Write("да");
}
else
{
    Console.Write("нет");
}
