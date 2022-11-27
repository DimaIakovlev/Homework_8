// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = CreateRandomArray(rows, columns, 0, 10);
ShowArray(myArray);

Console.WriteLine($"Строка с наименьшей суммой чисел - {GetRowNumber(myArray)}");



int[,] CreateRandomArray(int rows, int columns, int min, int max)
{
    int[,] randomArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomArray[i, j] = new Random().Next(min, max + 1);
        }

    }
    return randomArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }

}

int GetRowNumber(int[,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minsum = minsum + array[0, i];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}