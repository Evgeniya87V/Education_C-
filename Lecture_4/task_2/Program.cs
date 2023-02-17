// Матрица из чисел

void PrintArray(int[,]  matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  //0-первое чило из [3,4]
    {
        for (int j = 0; j < matr.GetLength(1); j++) //1 -второе число из[3,4]
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
//добавим метод который будет заполнять матрицу случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); //[1;10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
