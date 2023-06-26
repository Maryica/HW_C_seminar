// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


string Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine()!;
    return number;
}

void Palindrome(string num)
{
    for (int i = num.Length - 1; i > -1; --i)
    {
        Console.Write((num[i]));
    }
    Console.WriteLine();
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - Не палиндром");
    }
}

string number = Prompt("Введите пятизначное число: ");
Palindrome(number);



// int Prompt(string message)
// {
//     Console.Write(message);
//     string? value = Console.ReadLine();
//     int number = Convert.ToInt32(value);
//     return number;
// }
// int ReverseNumber(int a)
// {
//     int revNum = 0;
//     int temp = a;
//     while (temp > 0)
//     {
//         revNum = revNum * 10 + temp % 10;
//         temp /= 10;
//     }
//     return revNum;
// }

// int a = Prompt("Введите 5-и значное число: ");
// int reversed = ReverseNumber(a);

// if (a > 9999 && a < 1000000)
// {
//     if (reversed == a)
//     {
//         Console.WriteLine("Число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Число не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
// }
