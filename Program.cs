// task 1
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

/*Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int second_number = (number / 10) % 10;

        Console.WriteLine($"Вторая цифра числа: {second_number}");*/

// task 2
/*Напишите программу, которая выводит третью цифру заданного числа.*/
/*
Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int thirdDigit = GetThirdDigit(number);

        if (thirdDigit != -1)
        {
            Console.WriteLine($"Третья цифра числа: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }

    static int GetThirdDigit(int number)
    {
        if (number >= 100 && number <= 999)
        {
            int thirdDigit = (number / 10) % 10;
            return thirdDigit;
        }
        else
        {
            return -1;
        }
    }
    */

// Task3

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

/*int Prompt(string msg)
{

System.Console.WriteLine($»{msg}»);
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt(«Введите число»);
string ss = «Это не день недели»;
string check(int number)
{
if (number >= 6 && number < 8) ss = «Это выходной»;
if (number >= 1 && number < 7) ss = «Это будний день»;
return ss;
}
System.Console.WriteLine(check(number));*/