using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Services

{
    public class LibraryService
    {
        private readonly ILogger _logger;

        public LibraryService(ILogger logger)
        {
            _logger = logger;
        }

        public void PerformLibraryTask()
        {
            _logger.Log("Library task executed successfully!");
        }
    }
}

