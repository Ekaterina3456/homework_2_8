//Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] array = new int[4, 4];
int n = 1;
int i = 0, j = 0, k = 0, l = 0;

while (n <= 16)
{
    for (i = k; i < 4 - k; i++)
        array[k, i] = n++;
    for (j = l + 1; j < 4 - l; j++)
        array[j, 3 - l] = n++;
    for (i = 2 - k; i >= k; i--)
        array[3 - k, i] = n++;
    for (j = 2 - l; j > l; j--)
        array[j, l] = n++;
    k++;
    l++;
}

for (i = 0; i < 4; i++)
    {
        for (j = 0; j < 4; j++)
    {
        Console.Write("{0} ", array[i, j].ToString("D2"));
    }
    Console.WriteLine();
}