using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaFerias.API.Data;
using SistemaFerias.API.Models;

namespace SistemaFerias.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitacoesFeriasController : ControllerBase
    {
        AppDbContext _dbcontext;
        public SolicitacoesFeriasController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbcontext.SolicitacoesFerias);
        }

        [HttpPost]
        public IActionResult SolicitarFerias([FromBody] SolicitacaoFerias novaSolicitacao)
        {
            if (novaSolicitacao == null || string.IsNullOrWhiteSpace(novaSolicitacao.NomeFuncionario))
            {
                return BadRequest("Por gentileza completar os dados faltantes");
            }
            else if (novaSolicitacao.Dias != 20 && novaSolicitacao.Dias != 30)
            {
                return BadRequest("A Solicitação só pode ser feita de 20 ou 30 dias ");
            }
            novaSolicitacao.DataFim = novaSolicitacao.DataInicio.AddDays(novaSolicitacao.Dias);
            novaSolicitacao.DataSolicitacao = DateTime.Now;

            _dbcontext.SolicitacoesFerias.Add(novaSolicitacao);
            _dbcontext.SaveChanges();
            return Ok(novaSolicitacao);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var delete = _dbcontext.SolicitacoesFerias.FirstOrDefault(x => x.Id == id);
            if (delete == null)
            {
                return NotFound("Não é possivel deletar a solicitação");
            }
            _dbcontext.SolicitacoesFerias.Remove(delete);
            _dbcontext.SaveChanges();
            return NoContent();
        }
    }
}
