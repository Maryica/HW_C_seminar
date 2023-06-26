// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int sumDigits(int n)
{
    int Num = 0;
    int numb = n;
    int Num_s = 0;
    while (numb > 0)
    {
        Num = numb % 10;
        numb /= 10;
        Num_s = Num_s + Num;
    }
    Console.WriteLine($"Сумма цифр числа {n} = {Num_s}");
    return numb;


}

int number = Prompt("Введите число: ");
sumDigits(number);