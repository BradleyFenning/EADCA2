using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using CA2WebService;
using CA2WebService.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ProjectContext _projectContext;



        public LibraryController(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Library> libraries = await _projectContext.Libraries.ToListAsync();

            return Ok(libraries);
        }


        [HttpGet("books")]
        public async Task<IActionResult> GetBooks()
        {
            List<Book> books = await _projectContext.Books.ToListAsync();

            return Ok(books);
        }
    }
}