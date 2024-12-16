using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using Microsoft.Extensions.Logging;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up LoggerService using Dependency Injection
            ILogger logger = new LoggerService();
            var libraryService = new LibraryService(logger);

            // Perform a library task
            libraryService.PerformLibraryTask();

            // Set up library data
            var book = new Book { Title = "Introduction to C#", Author = "John Smith" };
            var user = new User { Name = "Alice" };

            // Borrow a book
            var borrowService = new BorrowService();
            borrowService.BorrowBook(book, user);
        }
    }
}
