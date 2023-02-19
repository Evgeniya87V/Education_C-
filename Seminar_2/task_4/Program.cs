/*
Напишите программу, которая на вход принимает число и
 проверяет кратно оно одновременно 7 и 23
 */

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int enteredNumber = numberRequest("Enter number: ");

if (enteredNumber % 7 == 0 && enteredNumber % 23 == 0)
{
    Console.WriteLine("Да");
}
else 
Console.WriteLine($"Нет");
