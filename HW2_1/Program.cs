// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = int.Parse(Console.ReadLine()!);
if (99 < number && number < 1000)
{
    int newNumber = number % 100;
    int secondDigit = newNumber / 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Ошибка, введите трёхзначное число");
}