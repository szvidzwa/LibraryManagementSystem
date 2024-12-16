using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Services
{
    public class LoggerService : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Log]: {message}");
        }
    }
}
