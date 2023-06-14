// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int number_1 = int.Parse(Console.ReadLine()!);
int number_2 = int.Parse(Console.ReadLine()!);
if (number_1 > number_2)
{
    Console.WriteLine("max = " + number_1 + ", min = " + number_2);
}
//можно добавить ветвление else if если числа равны, но в условии этого не было
// else if (number_1 == number_2)
// {
//     Console.WriteLine(number_1 + " и " + number_2 + " равны");
// }
else
{
    Console.WriteLine("max = " + number_2 + ", min = " + number_1);
}