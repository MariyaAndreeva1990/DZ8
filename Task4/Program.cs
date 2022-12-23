/*
Сформируйте трёхмерный массив 
из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int rows = 2;
int columns = 2;
int pages = 2;

int[,,] numbers = new int[rows, columns, pages];
FillArray3D(numbers);
WriteArray3D(numbers);


void WriteArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i}, {j}, {k}); ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray3D(int[,,] array3D)
{
    int[] size = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    for (int i = 0; i < size.GetLength(0); i++)
    {
        size[i] = new Random().Next(10, 100);
        int number = size[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (size[i] == size[j])
                {
                    size[i] = new Random().Next(10, 100);
                    j = 0;
                    number = size[i];
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = size[count];
                count++;
            }
        }
    }
}
