using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class LoggerDecorator : LibraryNotifier
    {
        private readonly LibraryNotifier _notifier;

        public LoggerDecorator(LibraryNotifier notifier)
        {
            _notifier = notifier;
        }

        public override void Notify(string message)
        {
            _notifier.Notify(message); // Forward the message
            LogNotification(message);
        }

        private void LogNotification(string message)
        {
            Console.WriteLine($"[Log]: {message}");
        }
    }
}

