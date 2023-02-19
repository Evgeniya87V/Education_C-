/* Напишите программу, которая на вход принимает два числа и выводить 
является ли второе число кратное первому, если не кратное, то программа
 выводит остаток от деления
*/

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberOne = numberRequest("Введите первое число ");
int numberTwo = numberRequest("Введите второе число ");

if (numberOne % numberTwo == 0)
{
    Console.WriteLine("Кратно!");
}
else 
Console.WriteLine($"Не кратно. Остаток от деления {numberOne % numberTwo}");