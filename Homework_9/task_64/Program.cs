﻿/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите натуральное число больше 1: ");
int naturalNumber = int.Parse(Console.ReadLine());

void NumberCounter (int naturalNumber)
{
    if (naturalNumber < 0) Console.Write($"{naturalNumber} не натуральное число");
    if (naturalNumber  == 0) return;
    Console.Write("{0,4}", naturalNumber);
    NumberCounter (naturalNumber - 1);
}

NumberCounter(naturalNumber);

