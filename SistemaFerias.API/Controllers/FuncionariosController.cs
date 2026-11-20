using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaFerias.API.Data;
using SistemaFerias.API.Models;

namespace SistemaFerias.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly AppDbContext _dbcontext;
        public FuncionariosController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_dbcontext.Funcionarios);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var funcionarios = _dbcontext.Funcionarios.Find(id);
            if (funcionarios == null) return NotFound(new { erro = "Funcionario não encontrado" });
            return Ok(funcionarios);
        }

        [HttpPost]
        public IActionResult CadastrasFuncionario(Funcionario novoFuncionario)
        {
            if (novoFuncionario == null) return BadRequest(new { erro = "Preencha os dados corretamente" });

            novoFuncionario.DataCriacao = DateTime.Now;
            _dbcontext.Funcionarios.Add(novoFuncionario);
            _dbcontext.SaveChanges();
            return Ok(novoFuncionario);

        }
    }
}
