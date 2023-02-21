/* Напишите программу, которая на вход принимает координаты двух точек
и находит расстояние между ними в 2D пространстве
А (3,6); В (2,1) -> 5,09
Корень ((х1-х2)^2 + (у1 -у2)^2)
Math.Sqrt()
Math.Pow (выражение, степень)
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("ВВели не число. Повторите ввод");
        }
    }

    return result;
}

int x1 = GetNumber("Введите координату X первой точки:");
int y1 = GetNumber("Введите координату Y первой точки:");

int x2 = GetNumber("Введите координату X второй точки:");
int y2 = GetNumber("Введите координату Y второй точки:");

double GetDistance(int x1,int x2,int y1,int y2)
{
    double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow (y1 -y2,2));
    return result;
}
Console.WriteLine(GetDistance(x1,x2,y1,y2));