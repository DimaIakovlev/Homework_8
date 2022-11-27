//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//  Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
//  Результирующая матрица будет:
//  18 20
//  15 18


Console.Clear();
Console.Write("Введите количество строк 1 массива: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columns1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columns2 = int.Parse(Console.ReadLine());

if (columns1 != rows2)
{
    Console.Write("Произведение таких матриц невозможно!! ");
    return;
}

int[,] Array1 = CreateRandomArray(rows1, columns1, 0, 10);
int[,] Array2 = CreateRandomArray(rows2, columns2, 0, 10);

ShowArray(Array1);
Console.WriteLine();
ShowArray(Array2);
Console.WriteLine();
ShowArray(GetMultiplicationMatrix(Array1, Array2));

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

int[,] GetMultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
           for (int k = 0; k < array1.GetLength(1); k++)
           {
            array3 [i,j] += array1[i,k]*array2[k,j];  
           }
        }

    }
    return array3;
}