// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] RandomArray()
{
    int[] array = new int[8];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}


int[] array = RandomArray();
PrintArray(array);