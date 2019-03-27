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
    public class UsuarioController : ControllerBase
    {
        private readonly EnglishAppContext _context;

        public UsuarioController(EnglishAppContext context)
        {
            _context = context;
        }

        // public async Task<ActionResult> Post(Usuario usuario)
        // {
        //     _context.Usuarios.Add(usuario);
        //     await _context.SaveChangesAsync();

        //     return Ok();

        //     // return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
        // }

        public void Post(Usuario usuario) 
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }
    }
}