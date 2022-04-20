using System;
using System.Collections.Generic;

namespace CA2WebService
{
    public class Library
    {
        public int LibraryID { get; set; }
        public string LibraryName { get; set; }
        public string Address { get; set; }

    }

    public class Book
    {

        public int ID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public bool AvailableForLoan { get; set; }
        public int LibraryID { get; set; }

    }
}
