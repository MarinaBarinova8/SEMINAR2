// Задача 3.  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
 

 void WeekDay(int number)
{
    if(number > 5 && number <8 )
Console.Write("This day of the week is  weekend");
    else
    Console.Write("This day of the week is not weekend");
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

WeekDay(num);