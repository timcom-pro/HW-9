/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if (m != 0 && n == 0)
        return Ackerman(m - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine("Programm will calculate the Ackermann function for M and N numbers.");
Console.WriteLine("Please, enter M:");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Please, enter N:");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Result is: {Ackerman(numberM, numberN)}.");