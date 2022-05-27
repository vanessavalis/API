using API.Context;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefasController : ControllerBase
    {
        public readonly DataContext _context;
        public TarefasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult get()
        {
            var dados = _context.Tarefas.ToList();         
            return Ok(dados);
        }

        [HttpGet("Pesquisa-por-nome")]
        public ActionResult getByNome(string nome)
        {
            var dados = _context.Tarefas.Where(p => 
                                            p.Nome.Contains(nome.ToUpper()) || 
                                            p.Descricao.Contains(nome.ToUpper())
                                        ).ToList();
            return Ok(dados);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Tarefas tarefas)
        {
            _context.Tarefas.Add(tarefas);
            _context.SaveChanges();

            return Ok(tarefas);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Tarefas tarefas)
        {
            var tarefa = _context.Tarefas.FirstOrDefault(p => p.Id == tarefas.Id);
            if (tarefa == null)
            {
                return NotFound();
            }
            tarefa.Nome = tarefas.Nome.ToUpper();
            tarefa.Descricao = tarefas.Descricao.ToUpper();
            tarefa.DataInicio = tarefas.DataInicio;
            tarefa.DataFim = tarefas.DataFim;

            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();

            return Ok(tarefas);
        }

        [HttpDelete]
        public ActionResult Delete([FromQuery] int id)
        {
            var tarefa = _context.Tarefas.FirstOrDefault(p => p.Id == id);
            if (tarefa == null)
            {
                return NotFound();
            }

            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();

            return Ok();
        }

    }
}
