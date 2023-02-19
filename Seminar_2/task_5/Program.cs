/* Напишите программу которая на вхлд принимает два числа и 
проверяет является ли одно число квадратом другого
*/
int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberOne = NumberRequest("Enter number: ");
int numberTwo = NumberRequest("Enter number: ");

if (numberOne * numberOne == numberTwo || numberTwo * numberTwo == numberOne)
{
    Console.WriteLine("Да");
}
else 
Console.WriteLine($"Нет");
