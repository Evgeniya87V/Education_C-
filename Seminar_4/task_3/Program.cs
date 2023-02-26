/*
Задача 28. Напишите программу, которая на вход принимает число N 
и выдает произведение чисел от 1 до N.
4-> 24
5-> 120
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

int GetMultiOfNumber(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
       mult = mult * i; 
    }
    return mult;
}

int number = GetNumber("Введите число больше 0: ");
int mult = GetMultiOfNumber(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {mult}");
