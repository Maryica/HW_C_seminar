// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int number_1 = int.Parse(Console.ReadLine()!);
int number_2 = int.Parse(Console.ReadLine()!);
int number_3 = int.Parse(Console.ReadLine()!);

if (number_1 > number_2 && number_1 > number_3)
{
    Console.WriteLine(number_1);
}
else if (number_2 > number_1 && number_2 > number_3)
{
    Console.WriteLine(number_2);
}
else
{
    Console.WriteLine(number_3);
}