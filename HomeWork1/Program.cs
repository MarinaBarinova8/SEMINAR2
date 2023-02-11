// Задача 1. Напишите программу, которая принимает за вход трехзначное число и на выходе показывает вторую цифру этого числа

int Digits (int number)
{
    int num1 = number / 10;
    int num2 = num1 % 10;
    return num2;
}

Console.Write("Input your three-digit number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
int result = Digits(user_number);
Console.WriteLine($"Your number is {result}");
