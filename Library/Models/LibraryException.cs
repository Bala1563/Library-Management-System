﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class LibraryException : Exception
    {
        public LibraryException(string msg) : base(msg) { }
    }
}