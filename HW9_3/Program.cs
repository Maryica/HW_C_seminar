// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}

int M = Prompt("Введите число M больше 0: ");
int N = Prompt("Введите число N больше 0: ");
Console.Write($"Функция Аккермана = {AckermanFunction(M, N)}");