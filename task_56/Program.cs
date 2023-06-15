// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandom2DArray()

{

    int[,] array = new int[4, 3];

    for (int i = 0; i < 4; i++)

        for (int j = 0; j < 3; j++)

            array[i, j] = new Random().Next(1, 9);

    return array;

}

void Show2DArray(int[,] array)

{

    for (int i = 0; i < 4; i++)

    {

        for (int j = 0; j < 3; j++)

            Console.Write(array[i, j] + " ");

        Console.WriteLine();

    }

    Console.WriteLine();

}

int SumLine(int[,] array, int i)

{

    int sum = array[i, 0];

    for (int j = 1; j < array.GetLength(1); j++)

    {

        sum += array[i, j];

    }

    return sum;

}

int[,] myArray = CreateRandom2DArray();

Show2DArray(myArray);

int minSum = 1;

int sum = SumLine(myArray, 0);

for (int i = 1; i < myArray.GetLength(0); i++)

{

    if (sum > SumLine(myArray, i))

    {

        sum = SumLine(myArray, i);

        minSum = i + 1;

    }

}

Console.WriteLine("Сумма элементов строки 1 равна " + SumLine(myArray, 0));

Console.WriteLine("Сумма элементов строки 2 равна " + SumLine(myArray, 1));

Console.WriteLine("Сумма элементов строки 3 равна " + SumLine(myArray, 2));

Console.WriteLine("Сумма элементов строки 4 равна " + SumLine(myArray, 3));

Console.WriteLine("Строка c наименьшей суммой элементов это строка: " + minSum);