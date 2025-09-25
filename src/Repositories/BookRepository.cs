using System.Collections.Generic;
using System.Data.SQLite;
using LibrarySystem.Models;

namespace LibrarySystem.Repositories
{
    public class BookRepository
    {
        private readonly string _connectionString = "Data Source=library.db;Version=3;";

        public BookRepository()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            var command = new SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS Books (Id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT NOT NULL, Author TEXT NOT NULL, Year INTEGER NOT NULL)",
                connection);
            command.ExecuteNonQuery();
        }

        public void AddBook(Book book)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            var command = new SQLiteCommand(
                "INSERT INTO Books (Title, Author, Year) VALUES (@title, @author, @year)",
                connection);
            command.Parameters.AddWithValue("@title", book.Title);
            command.Parameters.AddWithValue("@author", book.Author);
            command.Parameters.AddWithValue("@year", book.Year);
            command.ExecuteNonQuery();
        }

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            var command = new SQLiteCommand("SELECT * FROM Books", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                books.Add(new Book(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetInt32(3)
                ));
            }
            return books;
        }
    }
}
