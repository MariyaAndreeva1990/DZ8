/*
Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой 
строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
int[] sums = new int[numbers.GetLength(0)];
int indexSum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sums[indexSum] += numbers[i, j];
    }
    indexSum++;
}
WriteOneDimensional(sums);

int min = sums[0];
for (int i = 0; i < sums.Length; i++)
{
    if (sums[i] < min)
    {
        min = sums[i];
    }
}
int position = IndexOf(sums, min);

Console.Write($"Минимальная сумма {min} в {position} строке");


void FillMatrixRandomNumbers(int[,] array, int min = 1, int max = 10)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteOneDimensional(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        {
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine();
}

int IndexOf(int[] collection, int find)// ищет в массиве указанный элемент и "возвращает" его позицию
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}