// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SelectionSort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            for (int n = 0; n < arr.GetLength(1) - 1; n++)
            {
                if (arr[i, n] < arr[i, n + 1])
                {
                    int temporary = arr[i, n + 1];
                    arr[i, n + 1] = arr[i, n];
                    arr[i, n] = temporary;
                }
            }
        }
    }
}



int rows = Prompt("Введите колличество строк: ");
int columns = Prompt("Введите колличество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
SelectionSort(array);
PrintArray(array);