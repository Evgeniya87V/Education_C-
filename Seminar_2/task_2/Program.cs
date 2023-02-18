/*Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа*/

int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000); // [left, right)
    return result;
}

int GetDeletOfSecondNumber(int number)
//145
{
    int firstDigit = number / 100; //1,45-> без остатка 1
    int ThirdDigit = number % 10; // 14,5 -> остаток 5
    return firstDigit * 10 + ThirdDigit;
}

int number = GetNumber();
int result = GetDeletOfSecondNumber(number);

Console.WriteLine($"Было: {number} Стало: {result}");
