// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] MultiMatrix(int[,] a, int[,] b)
{
    int rowsA = a.GetLength(0);
    int colsA = a.GetLength(1);
    int rowsB = b.GetLength(0);
    int colsB = b.GetLength(1);
    int[,] result = new int[rowsA, colsB];
    for (int i = 0; i < rowsA; i++)
        for (int j = 0; j < colsB; j++)
            for (int k = 0; k < colsA; k++)
                result[i, j] += a[i, k] * b[k, j];
    return result;
}

int[,] matrix1 =
{
    { new Random().Next(1, 10), new Random().Next(1, 10)},
    { new Random().Next(1, 10), new Random().Next(1, 10) },
};

int[,] matrix2 =
{
    { new Random().Next(1, 10), new Random().Next(1, 10) },
    { new Random().Next(1, 10), new Random().Next(1, 10) },
};

void PrintMatrix(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    for (int i = 0; i < rowCount; i++)
        for (int j = 0; j < colCount; j++)
            Console.Write(matrix[i, j] + " | ");
    Console.WriteLine();
}

System.Console.WriteLine("Матрицы:");
PrintMatrix(matrix1);
PrintMatrix(matrix2);
int[,] result = MultiMatrix(matrix1, matrix2);
System.Console.WriteLine();
System.Console.WriteLine("Произведение матриц:");
PrintMatrix(result);