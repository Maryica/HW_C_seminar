// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    Random num = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = num.Next(1, 50);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");

        }
        Console.WriteLine();
    }
}

void FindSmallestAmount(int[,] arr)
{
    int sum = 0;
    int minSum = 0;
    int row = 0;
    for (int r = 0; r < arr.GetLength(1); r++)
    {
        row += arr[0, r];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) sum += arr[i, j];
        Console.WriteLine($"Строка {i + 1} сумма {sum}  ");
        if (sum < row)
        {
            row = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов: {minSum + 1} строка");
}



int[,] array = GetArray(3, 5);
PrintArray(array);
FindSmallestAmount(array);

