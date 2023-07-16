// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

// a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//int numberA = Console.ReadLine("Введите первое число ");
//int numberB = Console.ReadLine("Введите второе число ");

int numberA = 5;
int numberB = 2;

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