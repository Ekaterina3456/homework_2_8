// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.


void CreateArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortFromMaxToMin(int[,] array)

{

    for (int i = 0; i < array.GetLength(0); i++)

    {

        for (int j = 0; j < array.GetLength(1); j++)

        {

            for (int k = 0; k < array.GetLength(1) - 1; k++)

            {

                if (array[i, k] < array[i, k + 1])

                {

                    int temp = array[i, k + 1];

                    array[i, k + 1] = array[i, k];

                    array[i, k] = temp;

                }

            }

        }

    }

}

Console.WriteLine("введите размерность строки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите размерность столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];
CreateArray(array);
PrintArray(array);
SortFromMaxToMin(array);
PrintArray(array);