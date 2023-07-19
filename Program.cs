/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

void ShowNaturalNumsFromNto1(int n)
{
    if (n > 1)
    {
        Console.Write($"{n}, ");
        ShowNaturalNumsFromNto1(n - 1);
    }
    if (n < 1)
    {
        Console.Write("Incorrect input of N!");
    }
    else
    {
        if (n == 1)
            Console.Write($"{n}");
    }
}

Console.WriteLine("Programm will show all natural numbers from N till 1.");
Console.WriteLine("Please, enter N:");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Result is:");
ShowNaturalNumsFromNto1(number);