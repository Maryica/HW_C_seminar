// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. (Вывод четных)
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задание из PDF-файла:
// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"



int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

// Задание из PDF:
// string Natural(int num1, int num2)
// {
//     if (num1 > num2)
//     {
//         if (num1 == num2)
//         {
//             return num2.ToString();
//         }
//         return num1.ToString() + ", " + Natural(num1 - 1, num2);

//     }
//     else
//     {
//         if (num2 == num1)
//         {
//             return num1.ToString();
//         }
//         return Natural(num2 - 1, num1) + ", " + num2.ToString();

//     }

// }


// Для PDF:
// int number1 = Prompt("Введите число: ");
// int number2 = Prompt("Введите число: ");
// Natural(number1, number2);
// Console.WriteLine($"{Natural(number1, number2)}");


//Для задания с сайта:

string Natural(int num)
{

    if (num == 2)
    {
        return "2";
    }
    if (num % 2 == 0)
    {
        return num.ToString() + ", " + Natural(num - 2);
    }

    else
    {
        return Natural(num - 1) + " ";
    }
}

int number = Prompt("Введите число: ");
Natural(number);
Console.WriteLine($"{Natural(number)}");


