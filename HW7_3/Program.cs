// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double[] ArithmeticMean(int[,] arr)
{

    double[] arrColumns = new double[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];

        }
        arrColumns[j] = Math.Round(sum / arr.GetLength(0), 2);
    }
    return arrColumns;
}


int rows = Prompt("Введите колличество строк: ");
int columns = Prompt("Введите колличество столбцов: ");
int[,] array = GetArray(rows, columns);
double[] mean = ArithmeticMean(array);
PrintArray(array);
Console.WriteLine($"Среднее арифметическое столбца = {String.Join("; ", mean)}");
