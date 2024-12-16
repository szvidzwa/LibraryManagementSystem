using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces
{
    public interface IBookOperations
    {
        void BorrowBook(Book book, User user);
        void ReturnBook(Book book, User user);
    }
}
