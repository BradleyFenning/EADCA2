using System;
using System.Collections.Generic;

namespace CA2WebService
{
    public class Library
    {
        public int LibraryID { get; set; }
        public string LibraryName { get; set; }
        public string Address { get; set; }
        public List<Book> BookList { get; set; }

    }

    public class Book
    {

        public int ID { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public int CurrentLibraryID { get; set; }
        public string CurrentLibraryName { get; set; }
        public bool AvailableForLoan { get; set; }

    }
}
