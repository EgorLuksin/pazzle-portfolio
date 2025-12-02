using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задание 1:");
        int[] a = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < a.Length; i ++)
        {
            Console.WriteLine(a[i]);
        }


        Console.WriteLine();
        Console.WriteLine("Задание 2:");

        double b = 0;
        a = new int[] { 3, 2 ,5 ,4 ,5 };
        for (int i = 0; i < a.Length; i ++)
        {
            b += a[i];
        }
        b /= a.Length;
        Console.WriteLine(b);


        Console.WriteLine();
        Console.WriteLine("Задание 3:");

        int[] c = { 45, 1, 89, 32, 56, 18, 76, 24 };
        int d = 0;
        foreach (int i in c)
        {
            if (i > d)
            {
                d = i;
            }
        }
        Console.WriteLine(d);


        Console.WriteLine();
        Console.WriteLine("Задание 4:");

        string[] fruit = { "Яблоко", "Груша", "Персик", "Абрикос", "Киви" };
        foreach (string s in fruit)
        {
            Console.Write(s + ", "); 
        }
        Console.WriteLine();


        Console.WriteLine();
        Console.WriteLine("Задание 5:");

        int[,] f =
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };

        for (int i = 0; i < f.GetLength(0); i++)
        {
            for (int j = 0; j < f.GetLength(1); j++)
            {
                Console.Write(f[i, j] + " ");
            }
            Console.WriteLine("");
        }


        Console.WriteLine();
        Console.WriteLine("Задание 6:");

        string str;
        do
        {
            Console.WriteLine("Введите пароль: ");
            str = Console.ReadLine();
            if (str == "1234")
            {
                Console.WriteLine("Доступ получен!");
                break;
            }
            Console.WriteLine("Пароль неверный!");
            Console.WriteLine("");
        } while (true);
    }
}