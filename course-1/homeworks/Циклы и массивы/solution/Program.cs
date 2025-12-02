using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задание 1:");
        int[] a = { 3, 4, 5, 2, 4, 3, 5 };
        double count = 0;
        int five = 0;
        int two = 0;

        foreach (int i in a)
        {
            if (i == 2)
            {
                two++; 
            } 
            else if (i == 5)
            {
                five++;
            }

            count += i;
        }
        Console.WriteLine("Средний балл: " + (count / a.Length));
        Console.WriteLine("Количество двоек: " + two);
        Console.WriteLine("Колличество пятёрок: " + five);


        Console.WriteLine();
        Console.WriteLine("Задание 2:");

        int[] b = { 1, 2, 3, 4, 5 };
        int len = b.Length;
        int[] c = new int[len];
        for (int i = 0; i < len; i ++)
        {
            Console.Write(b[i] + " ");
            c[len - i - 1] = b[i];
        }
        Console.WriteLine();
        foreach (int i in c)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < len; i++)
        {
            Console.Write(b[i] + " ");
        }
        Console.WriteLine();
        for (int i = len - 1; i >= 0; i--)
        {
            Console.Write(b[i] + " ");
        }


        Console.WriteLine();
        Console.WriteLine("Задание 3:");

        for (int i = 1; i <= 20; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 20; i++)
        {   
            if (i % 2 == 1)
            {
                continue;
            }
            Console.Write(i + " ");
        }
        Console.WriteLine();


        Console.WriteLine();
        Console.WriteLine("Задание 4:");

        string pasword = "1234";

        for (int i = 0; i < 4; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("Доступ заблокирован!");
                break;
            }
            Console.Write("Введите пароль: ");
            if (Console.ReadLine() == pasword)
            {
                Console.WriteLine("Доступ получен!"); 
                break; 
            }
            Console.WriteLine("Пароль неверный!");
            Console.WriteLine();
        }
    }
}