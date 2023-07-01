/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

const int ROWS = 3;
const int COLUMNS = 4;


int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int ChangeMatrix(int[,] matrix)
{
    int min = matrix.GetLength(0);
    int sum = 0;
    // for (int i = 0; i < matrix.GetLength(0); i++)
    // {
    //     /*for (int j = 0; j < matrix.GetLength(1); j++)
    //     {
    //         if (i==j)
    //         {
    //             sum+=matrix[i,j];
    //         }
    //     }*/

    // }
    if (matrix.GetLength(0) > matrix.GetLength(1))
    {
        min=matrix.GetLength(1);
    }
    for (int i = 0; i < min; i++)
    {
        sum=sum+matrix[i,i];
    }
    return sum;
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);

int myMatrix1 = ChangeMatrix(myMatrix);
Console.WriteLine($"[{string.Join(", ", myMatrix1)} ]");
