using System;

class Program
{
    static void Main()
    {
        int a, age, num, b, grade;
        string c, password;


        Console.WriteLine("Задние 1:");
        a = 10;

        if (a > 0)
        {
            Console.WriteLine("число положительное");
        }
        else if (a < 0)
        {
            Console.WriteLine("Чило отрицательное");
        }
        else
        {
            Console.WriteLine("Число раво нулю");
        }


        Console.WriteLine();
        Console.WriteLine("Задние 2:");

        Console.WriteLine("Введите ваш возраст:");
        age = int.Parse(Console.ReadLine());

        if (age > 18)
        {
            Console.WriteLine("Вы совершеннолетний");
        }
        else
        {
            Console.WriteLine("Вы не совершеннолетний");
        }

        Console.WriteLine();
        Console.WriteLine("Задние 3:");
        num = 7;

        if (num % 2 == 0)
        {
            Console.WriteLine("Число чётное");
        }
        else 
        { 
            Console.WriteLine("Число не чётное");
        }


        Console.WriteLine();
        Console.WriteLine("Задние 4:");
        a = 5;
        b = -2;

        if (a > 0 && b > 0)
        {
            Console.WriteLine("Оба числа положительны");
        }
        else if (a < 0 && b < 0)
        {
            Console.WriteLine("Оба числа отрицательны");
        }
        else if (a < 0)
        {
            Console.WriteLine("Число а - не положительно");
        }
        else if (a == 0)
        {
            Console.WriteLine("Число а равно 0");
        }
        else if (b == 0)
        {
            Console.WriteLine("Число b равно 0");
        }
        else
        {
            Console.WriteLine("Число b - не положительное");
        }    


        Console.WriteLine();
        Console.WriteLine("Задние 5:");

        Console.WriteLine("Введите вашу оценку:");
        grade = int.Parse(Console.ReadLine());
        if (grade < 3)
        {
            Console.WriteLine("Неудовлетворительно");
        }
        else if (grade == 3)
        {
            Console.WriteLine("Удовлетворительно");
        }
        else if (grade == 4)
        {
            Console.WriteLine("Хорошо");
        }
        else
        {
            Console.WriteLine("Отлично");
        }


        Console.WriteLine();
        Console.WriteLine("Задние 6:");

        Console.WriteLine("Введите первое число:");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите знак оперции:");
        c = Console.ReadLine();
        
        if (c == "+")
        {
            Console.WriteLine(a + " + " + b + " = " +  (a + b));
        }
        else if (c == "-")
        {
            Console.WriteLine(a + " - " + b + " = " + (a - b));
        }
        else if (c == "*")
        {
            Console.WriteLine(a + " * " + b + " = " + (a * b));
        }
        else if (c == "/")
        {
            Console.WriteLine(a + " / " + b + " = " + ((double)a / b));
        }


        Console.WriteLine();
        Console.WriteLine("Задние 7:");
        password = "Good_Password";

        Console.WriteLine("Введите пароль:");
        c = Console.ReadLine();

        if (password == c)
        {
            Console.WriteLine("Доступ получен");
        }
        else
        {
            Console.WriteLine("Доступ запрещён");
        }
    }
}