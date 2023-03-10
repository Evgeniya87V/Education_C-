/*
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("ВВели не число или 0. Повторите ввод");
        }
    }

    return result;
}

int number = GetNumber("Введите число N: ");

for (int i = 1; i <= Math.Abs(number); i++)
{ 
    Console.Write($"{i*i*i} ");
}
