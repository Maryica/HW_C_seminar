//  Задайте две матрицы. Напишите программу, 
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    Random num = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = num.Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // GetLength(0) - длина строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) // GetLength(1) - длина столбцов
        {
            Console.Write(arr[i, j] + " ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] PMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int rows = firstMatrix.GetLength(0);
    int columns = secondMatrix.GetLength(1);
    int[,] result = new int[rows, columns];
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int n = 0; n < firstMatrix.GetLength(1); n++)
                {
                    result[i, j] += firstMatrix[i, n] * secondMatrix[n, j];
                }
            }
        }
    }
    return result;
}

int[,] firstMatrix = GetArray(4, 4);
Console.WriteLine($"Первая матрица: ");
PrintArray(firstMatrix);
int[,] secondMatrix = GetArray(4, 4);
Console.WriteLine($"Вторая матрица: ");
PrintArray(secondMatrix);
int[,] productMatrix = PMatrix(firstMatrix, secondMatrix);
Console.WriteLine($"Произведение матриц: ");
PrintArray(productMatrix);

