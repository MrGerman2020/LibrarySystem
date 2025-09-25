using System;
using LibrarySystem.Repositories;
using LibrarySystem.Services;

namespace LibrarySystem
{
    class Program
    {
        static void Main()
        {
            var repository = new BookRepository();
            var service = new LibraryService(repository);

            while (true)
            {
                Console.WriteLine("\n1. Добавить книгу\n2. Показать книги\n3. Выход");
                Console.Write("Выберите действие: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Название: ");
                        var title = Console.ReadLine();
                        Console.Write("Автор: ");
                        var author = Console.ReadLine();
                        Console.Write("Год: ");
                        if (int.TryParse(Console.ReadLine(), out int year))
                            service.AddBook(title, author, year);
                        else
                            Console.WriteLine("Некорректный год.");
                        break;
                    case "2":
                        foreach (var book in service.GetAllBooks())
                            Console.WriteLine($"ID: {book.Id}, Название: {book.Title}, Автор: {book.Author}, Год: {book.Year}");
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }
}
