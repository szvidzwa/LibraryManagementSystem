﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibraryManagementSystem.Services
{
    public class LibraryNotifier
    {
        public virtual void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
