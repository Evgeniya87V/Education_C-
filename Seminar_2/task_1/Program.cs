/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа
Например:
78->8
12->2
85->8
1. получить рамдобное число в заданном диапазоне
2. получить максимальную цифру числа
*/

int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(10, 100); // [left, right)
    return result;
}

int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if(firstDigit > secondDigit)
       return firstDigit;
    else 
       return secondDigit;
}

int number = GetNumber();
int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Максимальная цифра числа {number} = {maxDigit}");
