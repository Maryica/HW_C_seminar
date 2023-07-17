// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


int Sum(int m, int n)
{
    int res = m;
    if (m < n)
    {

        if (m == n)
            return 0;
        else
        {
            m++;
            res = m + Sum(m, n);
            return res;
        }
    }
    else
    {
        if (n == m)
            return 0;
        else
        {
            n++;
            res = m + Sum(m, n);
            return res;
        }

    }
}

void SumFromMToN(int m, int n)
{
    if (m < n)
    {
        Console.Write($"Сумма натуральных элементов в промежутке от M до N = {Sum(m - 1, n)}");
    }
    else
    {
        Console.Write($"Сумма натуральных элементов в промежутке от M до N = {Sum(n - 1, m)}");
    }

}

int M = Prompt("Введите число: ");
int N = Prompt("Введите число: ");
Sum(M, N);
SumFromMToN(M, N);
