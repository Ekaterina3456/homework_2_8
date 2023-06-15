//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] array3d = new int[2, 2, 2];
for (int x = 0; x < array3d.GetLength(0); x++)
    for (int y = 0; y < array3d.GetLength(1); y++)
        for (int z = 0; z < array3d.GetLength(2); z++)
        {
            int number;
            bool found = false;
            do
            {
                number = new Random().Next(10, 100);
                found = false;
                for (int i = 0; i < array3d.GetLength(0) && !found; i++)
                    for (int j = 0; j < array3d.GetLength(1) && !found; j++)
                        for (int k = 0; k < array3d.GetLength(2) && !found; k++)
                            if (array3d[i, j, k] == number)
                                found = true;
            }
            while (found);
            array3d[x, y, z] = number;
        }

for (int x = 0; x < array3d.GetLength(0); x++)
    for (int y = 0; y < array3d.GetLength(1); y++)
        for (int z = 0; z < array3d.GetLength(2); z++)
            Console.WriteLine("{0}({1},{2},{3}) ", array3d[x, y, z], x, y, z);
Console.WriteLine();