// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


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
        result[i] = Prompt("Введите число: ");

    }
    return result;
}

int GreaterThanZero(int[] numbers)
{
    int result = 0;
    foreach (int el in numbers)
    {
        if (el > 0)
        {
            result++;
        }
    }
    Console.WriteLine($"Количество чисел больше 0 в массиве равно: {result}");
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


int lengthArr = Prompt("Введите длину массива: ");
int[] array = GetArray(lengthArr);
GreaterThanZero(array);
PrintArray(array);

