using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CA2WebService.Models
{
    public class ProjectContext : DbContext
    {
        public DbSet<Library> Libraries { get; set; }

        public DbSet<Book> Books { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=./Database/ProjectDB.db");


        Library L1 = new Library()
        {
            LibraryID = 10,
            LibraryName = "Tallaght Library",
            Address = "3 Tallaght Road"
        };

        Library L2 = new Library()
        {
            LibraryID = 11,
            LibraryName = "City Library",
            Address = "4 Reading Lane"
        };


        Book B1 = new Book()
        {
            ID = 1,
            BookName = "AGE PROOF",
            Author = "Professor Rose Anne Kenny",
            AvailableForLoan = false,
            LibraryID = 10,
        };

        Book B2 = new Book()
        {
            ID = 2,
            BookName = "VERITY",
            Author = "Colleen Hoover",
            AvailableForLoan = false,
            LibraryID = 10,
        };

        Book B3 = new Book()
        {
            ID = 3,
            BookName = "THE DEEP END",
            Author = "Jeff Kinney",
            AvailableForLoan = false,
            LibraryID = 10,
        };

        Book B4 = new Book()
        {
            ID = 4,
            BookName = "THE MAID",
            Author = "Nita Prose",
            AvailableForLoan = true,
            LibraryID = 10,
        };

        Book B5 = new Book()
        {
            ID = 5,
            BookName = "MANIFEST",
            Author = "Roxie Nafousi",
            AvailableForLoan = true,
            LibraryID = 10,
        };

        Book B6 = new Book()
        {
            ID = 6,
            BookName = "BIG SHOT",
            Author = "Jeff Kinney",
            AvailableForLoan = true,
            LibraryID = 10,
        };

        Book B7 = new Book()
        {
            ID = 7,
            BookName = "SMALL THINGS LIKE THESE",
            Author = "Claire Keegan",
            AvailableForLoan = true,
            LibraryID = 11,
        };

        Book B8 = new Book()
        {
            ID = 8,
            BookName = "AGAIN, RACHEL",
            Author = "Marian Keyes",
            AvailableForLoan = true,
            LibraryID = 11,
        };

        Book B9 = new Book()
        {
            ID = 9,
            BookName = "HOW TO MAKE YOUR MONEY WORK",
            Author = "Eoin McGee",
            AvailableForLoan = true,
            LibraryID = 11,
        };

        Book B10 = new Book()
        {
            ID = 1,
            BookName = "THE LETTER HOME",
            Author = "Rachael English",
            AvailableForLoan = false,
            LibraryID = 11,
        };




    }
}
