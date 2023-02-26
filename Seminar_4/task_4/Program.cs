/*
Напишите программу, которая выводит массив из 8 элементов
0 и 1 в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int[] array = new int[8];

void InitArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    Random rnd = new Random();
    while (index < length)
    {
        array[index] = rnd.Next(0,2);
        index++;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
InitArray(array);
PrintArray(array);