using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class BorrowService
    {
        public void BorrowBook(Book book, User user)
        {
            if (!book.IsBorrowed)
            {
                book.IsBorrowed = true;
                user.BorrowedBooksCount++;
                Console.WriteLine($"{user.Name} borrowed \"{book.Title}\".");
            }
            else
            {
                Console.WriteLine($"\"{book.Title}\" is already borrowed.");
            }
        }
    }
}