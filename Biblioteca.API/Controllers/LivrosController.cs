using Biblioteca.API.Data;
using Biblioteca.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LivrosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> GetLivros()
        {
            return await _context.Livro.ToArrayAsync();
        }

        [HttpPost]
        public async Task<ActionResult> CriarLivros(Livro livro)
        {
            _context.Livro.Add(livro);

            await _context.SaveChangesAsync();

            return Ok("Livro criado com sucesso!");
        }
    }
}

