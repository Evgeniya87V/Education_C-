// Двумерные массивы

string[,] table = new string[2, 5];
//String.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]


table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}


//еще пример

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)  //0-первое чило из [3,4]
{
    for (int j = 0; j < matrix.GetLength(1); j++) //1 -второе число из[3,4]
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}
