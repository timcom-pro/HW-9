/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int FindSumOfNumsFromMtoN(int m, int n)
{
    if (n < m)
        return 0;
    else
        return n + FindSumOfNumsFromMtoN(m, n - 1);

}

Console.WriteLine("Programm will show all natural numbers from M till N.");
Console.WriteLine("Please, enter M:");
int numberStart = int.Parse(Console.ReadLine()!);
Console.WriteLine("Please, enter N:");
int numberFinish = int.Parse(Console.ReadLine()!);


int result = FindSumOfNumsFromMtoN(numberStart, numberFinish);
if (result == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Incorrect input.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Result is: {result}.");
    Console.ResetColor();
}