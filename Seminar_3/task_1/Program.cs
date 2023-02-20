/* Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдвет номер четверти плоскости, в которой находится эта точка.
         Y
   2     |    1
         |
---------------->X
        |0
   3    |       4
        |
1. получить x и y c консоли.
2. получить номер четверти, где лежит точка с координатами (x,y)
3. вывести результат на экран
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

int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y >0)
        return 2;
    else if(x < 0 && y <0)
        return 3;
    else 
        return 4;
}

int x = GetNumber("Введите Х отличный от нуля:");
int y = GetNumber("Введите Y отличный от нуля:");
int quarter = GetQuarter(x,y);

Console.WriteLine($"точка с координатами ({x},{y}) лежит в {quarter} четверти");

/* 
1. reference types (ссылочный тип)
- class, array, list, char
- хранятся в управляемой кучи
- работаем с их ссылкой

2. value types (значимый тип)
- int, double, decimal, long, bit, byte,  
- хранятся в стеке(оперативная память компьютера/сервера/выделяемая память на облаке)
- работаем с их значениями
*/

/*
void Temp(int x)
{
    x = x * 10
}
int x = 5;
Temp(x);

Console.WriteLine(x); //5
*/
