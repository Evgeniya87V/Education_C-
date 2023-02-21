/*
принимает на вход число N и выдает таблицу квадратов чисел от 1 до N
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

int n = GetNumber("ВВедите число:");

for (int i = 1; i <= Math.Abs(n); i++)
{
    Console.Write($"{Math.Pow(i,2)} ");
}