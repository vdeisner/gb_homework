﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

// a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("max = ");
    Console.Write(numberA);
}
else
{
    Console.Write("max = ");
    Console.Write(numberB);
}