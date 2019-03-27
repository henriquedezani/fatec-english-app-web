using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnglishAppWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnglishAppWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly EnglishAppContext _context;

        public TurmaController(EnglishAppContext context)
        {
            _context = context;
        }

        public void Post(Turma e) 
        {
            _context.Turmas.Add(e);
            _context.SaveChanges();
        }

        [HttpPost("adicionausuario")]
        public void Post([FromQuery]int idTurma, [FromQuery]int idUsuario)
        {
            _context.TurmaUsuarios.Add(new TurmaUsuario { TurmaId = idTurma, UsuarioId = idUsuario});
            _context.SaveChanges();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var usuarios = _context.TurmaUsuarios.Where(t => t.TurmaId == id).Select(t => new {
                UsuarioId = t.Usuario.UsuarioId,
                Nome = t.Usuario.Nome,
                Email = t.Usuario.Email
            }).ToList();

            return Ok(usuarios);
        }
    }
}