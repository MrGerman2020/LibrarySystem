using System.Collections.Generic;
using LibrarySystem.Models;
using LibrarySystem.Repositories;

namespace LibrarySystem.Services
{
    public class LibraryService
    {
        private readonly BookRepository _repository;

        public LibraryService(BookRepository repository)
        {
            _repository = repository;
        }

        public void AddBook(string title, string author, int year)
        {
            var book = new Book(0, title, author, year);
            _repository.AddBook(book);
        }

        public List<Book> GetAllBooks()
        {
            return _repository.GetAllBooks();
        }
    }
}
