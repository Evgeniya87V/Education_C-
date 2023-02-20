/* 
Напишите программу, которая по заданному номеру четверти показывает  возможные координатв
точек в этой четверти х и у.
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result < 5 && result > 0)
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

void GetQuarter(int x)
{
    if(x == 1)
        Console.WriteLine("х > 0 и у > 0");
    else if(x == 2)
         Console.WriteLine("x < 0 и y >0");
    else if(x == 3)
        Console.WriteLine("x < 0 и y <0");
    else 
       Console.WriteLine("x > 0 и y >0");
}

int x = GetNumber("Введите номер четверти:");
GetQuarter(x);

