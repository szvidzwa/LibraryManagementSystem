using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up logger and notifier using Decorator Pattern
            LibraryNotifier baseNotifier = new LibraryNotifier();
            LibraryNotifier notifierWithLogging = new LoggerDecorator(baseNotifier);

            // Notify using the decorator
            notifierWithLogging.Notify("Library system is up and running.");

            // Set up BorrowService using the IBookOperations interface
            IBookOperations borrowService = new BorrowService();

            // Create library data
            var book = new Book { Title = "Introduction to C#", Author = "John Smith" };
            var user = new User { Name = "Alice" };

            // Borrow and return a book
            borrowService.BorrowBook(book, user);
            borrowService.ReturnBook(book, user);
        }
    }
}

