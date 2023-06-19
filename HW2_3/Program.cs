// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int number = int.Parse(Console.ReadLine()!);
if (number >= 1 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Не выходной");
    }
}
else
{
    Console.WriteLine("Эта цифра не обозначает день недели");
}
