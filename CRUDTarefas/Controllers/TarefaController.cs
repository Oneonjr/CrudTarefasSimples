using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDTarefas.models;
using CRUDTarefas.Context;

namespace CRUDTarefas.Controllers
{
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {   
        private readonly TarefaContext _context;

        public TarefaController(TarefaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _context.Add(tarefa);
            _context.SaveChanges();
            return Ok(tarefa);
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            var tarefas = _context.Tarefas.ToList();

            return Ok(tarefas);
        }

        [HttpGet("{id}")]
        public IActionResult obterporId(int id){
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
            {
                return NotFound();
            }

            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
            {
                return BadRequest( new { Erro = "Tarefa não encontrada"});  
            }

            tarefaBanco.nomeTarefa = tarefa.nomeTarefa;
            tarefaBanco.descricaoTarefa = tarefa.descricaoTarefa;
            tarefaBanco.Status = tarefa.Status;

            _context.Update(tarefaBanco);
            _context.SaveChanges();

            return Ok();

        }

        [HttpPatch("{id}")]
        public IActionResult AlterarStatus(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefa == null)
            {
                return BadRequest( new { Erro = "Tarefa não encontrada"});  
            }

            tarefaBanco.Status = tarefa.Status;

            _context.Update(tarefaBanco);
            _context.SaveChanges();

            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)    
            {
                return BadRequest( new { Erro = "Tarefa não encontrada"});  
            }

            _context.Remove(tarefaBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}