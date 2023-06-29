// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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
        result[i] = new Random().Next(0, 101);
    }
    return result;
}

int OddPositions(int[] arrNew)
{
    int sum = 0;
    for (int i = 0; i < arrNew.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + arrNew[i];
        }
    }
    Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {sum}");
    return sum;

}

void PrintArray(int[] arrPrint)
{
    for (int i = 0; i < arrPrint.Length; i++)
    {
        Console.Write($"{arrPrint[i]} ");
    }
    Console.WriteLine(); //Пустая строка для более аккуратного вывода значений
}



int lengthArr = Prompt("Введите длину массива: ");
int[] array = GetArray(lengthArr);
PrintArray(array);
OddPositions(array);