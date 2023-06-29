// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[] GetArray(int arrayLength)
{
    int[] result = new int[arrayLength];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1001);
    }
    return result;
}

void PrintArray(int[] arrPrint)
{
    for (int i = 0; i < arrPrint.Length; i++)
    {
        Console.Write($"{arrPrint[i]} ");
    }
    Console.WriteLine(); //Пустая строка для более аккуратного вывода значений
}


void CountingEven(int[] arrEven)
{
    int count = 0;
    foreach (int el in arrEven)
    {
        if (el % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {count}");
}


int lengthAr = Prompt("Введите длину массива: ");
int[] array = GetArray(lengthAr);
PrintArray(array);
CountingEven(array);