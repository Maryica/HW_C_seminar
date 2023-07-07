// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет


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
}


void ValueArray(int[,] arr, int line, int column) // поиск по заданным значениям массива

{
    if ((line <= 0 | line >= arr.GetLength(0)) | (column <= 0 | column >= arr.GetLength(1)))  // попадают указанные координаты в массив
    {
        Console.WriteLine($"[{line},{column}] на этой позиции числа в массиве нет");



    }
    else
    {
        Console.WriteLine("{0}", arr[line - 1, column - 1]);
    }
}


int lineСoordinate = Prompt("Введите позицию строки: ");
int columnCoordinate = Prompt("Введите позицию столбца: ");
int rows = 5;
int columns = 5;
int[,] array = GetArray(rows, columns);
PrintArray(array);
ValueArray(array, lineСoordinate, columnCoordinate);


