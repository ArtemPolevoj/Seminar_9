using Seminar_9;

Console.WriteLine("Задача 64: Задайте значение N.Напишите программу, которая выведет\n" +
 "все натуральные числа в промежутке от N до 1.");
int number = Value.getInt("Введите целое число");
Value.ValueOfN(number);
Console.WriteLine();

Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу,\n" +
    " которая найдёт сумму натуральных элементов в промежутке от M до N.");
int m = Value.getInt("Введите целое число");
int n = Value.getInt("Введите целое число");
int sum = 0;
Console.WriteLine($"Сумма натуральных элементов" +
    $" в промежутке от M до N = {Value.SumFromMtoN(m,n, ref sum)}");
Console.WriteLine();

Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана\n" +
    "с помощью рекурсии. Даны два неотрицательных числа m и n.");
int nK = Value.getInt("Введите целое число");
int mK = Value.getInt("Введите целое число");
Console.WriteLine($"A(m,n) = {Value.Akkermana(nK, mK)}");
