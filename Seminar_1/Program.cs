/* 
Напишите программу, которая на вход принимает число и выдает его квадрат(число умноженное само на себя)
пр: 4 -> 16
-3 -> 9
-7 -> 49
*/
Console.WriteLine("Введите число ");
string numberStr = Console.ReadLine(); //тип строка
int number = Convert.ToInt32(numberStr); // из типа строка получаем тип число
int result = number * number;
Console.WriteLine($"Квадрат числа {number} = {result}");

/*
Напишите программу, которая на вход принимает два числа и проверяет является ли первое
число квадратом второго
*/
Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a / b == b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}

/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру
3 -> среда
5 -> пятница
*/
Console.WriteLine("Введите число от 1 до 7: ");
string dayOfWeeks = Console.ReadLine();

if (dayOfWeeks == "1")
{
    Console.WriteLine("Сегодня Понедельник!");
}
else if (dayOfWeeks == "2")
{
    Console.WriteLine("Сегодня Вторник!");
}
else if (dayOfWeeks == "3")
{
    Console.WriteLine("Сегодня Среда!");
}
else if (dayOfWeeks == "4")
{
    Console.WriteLine("Сегодня Четверг!");
}
else if (dayOfWeeks == "5")
{
    Console.WriteLine("Сегодня Пятница!");
}
else if (dayOfWeeks == "6")
{
    Console.WriteLine("Сегодня Суббота!");
}
else if (dayOfWeeks == "7")
{
    Console.WriteLine("Сегодня Воскресенье!");
}
else
{
    Console.WriteLine("Введено неправильное число, повторите ввод числа");
}

/*
Напишите программу, которая принимает на вход одно число, 
а на выходе показывает все целые числа в промежутке от n до -n
*/
Console.WriteLine("Введите число: ");
int numb = Math.Abs(int.Parse(Console.ReadLine()));
for (int i = -numb; i <= numb; i++)
{
    Console.Write($"{i} ");
}

/*
Напишите программу, которая принимает на вход трехзначное число,
а на выходе показывает последнюю цифру этого числа
*/
Console.WriteLine("Введите трехзначное число: ");
string? numbStr = Console.ReadLine();
if (numbStr != null)
{
    int number1 = Math.Abs(int.Parse(numbStr));
    Console.WriteLine(number1 % 10);
}