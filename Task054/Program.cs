// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = CreateRandomArray(rows, columns, 0, 10);
ShowArray(myArray);
SortArray(myArray);
Console.WriteLine();
ShowArray(myArray);



int[,] CreateRandomArray(int rows, int columns, int min, int max)
{
    int[,] randomArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomArray[i, j] = new Random().Next(min, max);
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

void SortArray(int[,] array)
{
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = j + 1; t < array.GetLength(1); t++)
            {
                if (array[i, t] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, t];
                    array[i, t] = temp;
                }
            }
        }
    }
}