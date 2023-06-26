// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}




void exponentiation(int a, int b)
{
    int pr = 1;

    for (int i = 1; i <= b; i++)
    {
        pr = pr * a;
    }
    Console.WriteLine(pr);

}

int number_A = Prompt("Введите число A: ");
int number_B = Prompt("Введите число B: ");
exponentiation(number_A, number_B);