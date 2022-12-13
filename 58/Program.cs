// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

int[,] matrix = NewMatrix(2, 2, 1, 10);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] matrix2 = NewMatrix2(2, 2, 1, 10);
PrintMatrix(matrix2);
System.Console.WriteLine();
int[,] result = ValueTwoMatrix(matrix, matrix2);
PrintMatrix(result);

int[,] ValueTwoMatrix(int[,] matrix, int[,] matrix2)
{
    var valueTwoMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < valueTwoMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < valueTwoMatrix.GetLength(1); j++)
        {
            valueTwoMatrix[i, j] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                valueTwoMatrix[i, j] += matrix[i, k] * matrix2[k, j];
            }
        }
    }
    return valueTwoMatrix;
}

int[,] NewMatrix(int rows, int columns, int minElement, int maxElement)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minElement, maxElement + 1);
        }
    }
    return matrix;
}

int[,] NewMatrix2(int rows, int columns, int minElement, int maxElement)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(minElement, maxElement + 1);
        }
    }
    return matrix2;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

