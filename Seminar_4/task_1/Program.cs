/*
Задача 24. Напишите программу, которая на вход принимает число (А) 
и выдает сумму чисел от 1 до А.
7-> 28
4-> 10
8->36
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

int GetSum(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
       sum += i; 
    }
    return sum;
}

int number = GetNumber("Введите число больше 0: ");
int sum = GetSum(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
