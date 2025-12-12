using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


public class car1
{
    public string brand { get; set; }
    public int speed { get; private set; } = 0;

    public void accelerate() => speed += 10;
}

public class car2
{
    public string brand { get; }
    public int speed { get; private set; }

    public car2(string str, int speed = 0)
    {
        brand = str;
        this.speed = speed;
    }

    public void accelerate() => speed += 10;
}

public class book
{
    public string author { get; private set; }
    public string title { get; private set; }
    public int pages { get; private set; }

    public book (string title, int pages, string author = "Unknown")
    {
        this.author = author;
        this.title = title;
        this.pages = pages;
    }

    public void read(int page) 
    {
        if (page > pages)
        {
            Console.WriteLine($"Вы прочитали {pages} страниц из {pages}");
        }
        else
        {
            Console.WriteLine($"Вы прочитали {page} страниц из {pages}");
        }
    }
}

public class library
{
    public book[] books;
    public int books_index { get; private set; } = 0;
    public int max_books {  get; private set; }

    public library(int max_books)
    {
        books = new book[max_books];
        this.max_books = max_books;
    }

    public void add_book(string title, int pages, string author = "Unknown")
    {
        if (books_index < max_books)
        {
            books[books_index] = new book(title, pages, author);
            books_index++;
        }
        else
        {
            Console.WriteLine("Библиотека переполнена!");
            Console.WriteLine($"Невозможно поместить книгу^ {title}");
        }
    }

    public void print_all_books() 
    {
        for (int i = 0; i < books_index; i++)
        {
            Console.WriteLine($"Книга {i + 1}: автор {books[i].author}, название {books[i].title}, Страницы {books[i].pages}");
        }
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Задание 1:");

        var car = new car1{brand = "BMW"};
        car.accelerate();
        Console.WriteLine($"{car.brand} едет со скоростью {car.speed} км/ч");

        Console.WriteLine();
        Console.WriteLine("Задание 2:");
        var car2 = new car2("Audi", 50);
        car2.accelerate();
        Console.WriteLine($"{car2.brand} едет со скоростью {car2.speed} км/ч");


        Console.WriteLine();
        Console.WriteLine("Задание 3:");
        var book = new book("Гарри Поттер и философский камень", 432, "Джоан Роулинг");
        book.read(int.Parse(Console.ReadLine()));


        Console.WriteLine();
        Console.WriteLine("Задание 4:");

        var lib = new library(5);
        lib.add_book("1984", 350, "Дж. Оруэлл");
        lib.add_book("Гарри Поттер и философский камень", 432, "Джоан Роулинг");
        lib.add_book("Улисс", 1152, "Джеймс Джойс");
        lib.add_book("Война и мир", 1376, "Лев Толстой");
        lib.add_book("Сага о Форсайтах", 1424, "Джон Голсуорси");
        lib.add_book("Архипелаг ГУЛАГ", 1472, "Александр Солженицын");
        lib.print_all_books();
    }
}