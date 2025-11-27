using System;

class Program
{
    static void Main()
    {
        double a, b, c;

        Console.WriteLine("Задание 1:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine(a + "C = " + ((a * 9) / 5 + 32) + "F");

        Console.WriteLine();
        Console.WriteLine("Задание 2:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
        Console.WriteLine("Среднее арифметическое: " + ((a + b + c) / 3));

        Console.WriteLine();
        Console.WriteLine("Задание 3:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        Console.WriteLine(a + " + " + b + " = " + (a + b));

        Console.WriteLine();
        Console.WriteLine("Задание 4:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine(a + "RUB = " + (a * 72) + "USD, " + (a * 90) + "EUR, " + (a * 11) + "CNY");
    }
}