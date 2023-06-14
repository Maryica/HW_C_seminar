// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int number = int.Parse(Console.ReadLine()!);
int count = 0;
if (number % 2 == 0)
{
    while (count < number)
    {
        count = count + 2;
        Console.WriteLine(count);
    }

}
else
{
    while (count < (number - 1))
    {
        count = count + 2;
        Console.WriteLine(count);
    }

}