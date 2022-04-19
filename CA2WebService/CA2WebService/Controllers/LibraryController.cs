using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CA2WebService.Controllers
{
    [ApiController]
    [Route("api")]
    public class LibraryController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public LibraryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("GetLibraries")]
        public IEnumerable<Library> GetLibraries()
        {
            var libraries = new List<Library>();

            using (var connection = new SqlConnection(_configuration.GetConnectionString("LibraryDatabase")))
            {
                var sql = "SELECT ID, LibraryName, Address, BookList FROM Library";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var library = new Library()
                    {
                        LibraryID = (int)reader["ID"],
                        LibraryName = reader["LibraryName"].ToString(),
                        Address = reader["Address"].ToString(),
                        BookList = (List<Book>)reader["BookList"]
                    };
                    libraries.Add(library);
                }
            }
            return libraries;
        }


        [HttpGet("{LibraryID}/Books")]
        public IEnumerable<Book> GetBooks(int LibraryID)
        {
            var books = new List<Book>();

            using (var connection = new SqlConnection(_configuration.GetConnectionString("LibraryDatabase")))
            {
                var sql = "SELECT ID, BookName, Description, CurrentLibraryID, CurrentLibraryName, AvailableForLoan FROM Books WHERE CurrentLibraryID == " + LibraryID;
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var book = new Book()
                    {
                        ID = (int)reader["ID"],
                        BookName = reader["BookName"].ToString(),
                        Description = reader["Description"].ToString(),
                        CurrentLibraryID = (int)reader["CurrentLibraryID"],
                        CurrentLibraryName = reader["CurrentLibraryName"].ToString(),
                        AvailableForLoan = (bool)reader["AvailableForLoan"]
                    };
                    books.Add(book);
                }
            }
            return books;
        }
    }
}
