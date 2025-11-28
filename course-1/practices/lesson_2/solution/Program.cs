using System;

class Program
{
    static void Main()
    {
        int a = 12;
        int b = 5;

        Console.WriteLine("Задание 1:");
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);

        Console.WriteLine();
        Console.WriteLine("Задание 2:");
        Console.WriteLine("Введите ваше имя: ");
        Console.WriteLine("Привет, " + (Console.ReadLine() + "!"));

        Console.WriteLine();
        Console.WriteLine("Задание 3:");
        Console.WriteLine("Введите два числа:");
        string c = Console.ReadLine();
        string d = Console.ReadLine();
        Console.WriteLine(c + " + " + d + " = " + (int.Parse(c) + int.Parse(d)));

        Console.WriteLine();
        Console.WriteLine("Задание 4:");
        Console.WriteLine("Введите две стороны прямоугольника:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Площадь прямоугольника: " + (a * b));
    }
}