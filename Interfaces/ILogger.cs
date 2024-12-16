using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace LibraryManagementSystem.Interfaces
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
