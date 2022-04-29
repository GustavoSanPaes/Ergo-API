using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ErgoAPI.Data;
using ErgoAPI.Data.Dtos;
using ErgoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ErgoAPI.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class TarefaController : ControllerBase
    {
        private TarefaContext _context;
        private IMapper _mapper;

        public TarefaController(IMapper mapper)
        {
            _context = new TarefaContext();
            _mapper = mapper;
        }

        [HttpPost]
        public CreatedAtActionResult AdicionaTarefa([FromBody] CreateTarefaDto tarefaDto)
        {
            Tarefa tarefa = _mapper.Map<Tarefa>(tarefaDto);

            _context.Tarefas.Add(tarefa);
            _context.SavedChanges();
            return CreatedAtAction(nameof(RecuperaTarefaPorId), new { Id = tarefa.Id }, tarefa);
        }

        [HttpGet]
        public IEnumerable<Tarefa> RecuperaTarefas()
        {
            return _context.Tarefas.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaTarefaPorId(int id)
        {
            Tarefa tarefa = _context.Tarefas.FirstOrDefault(tarefa => tarefa.Id.Equals(id));
            if (tarefa != null)
            {
                ReadTarefaDto tarefaDto = _mapper.Map<ReadTarefaDto>(tarefa);
                
                return Ok(tarefaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaTarefa(int id, [FromBody] UpdateTarefaDto tarefaDto)
        {
            Tarefa tarefa = _context.Tarefas.FirstOrDefault(tarefa => tarefa.Id.Equals(id));
            if (tarefa == null)
            {
                return NotFound();
            }
                _mapper.Map(tarefaDto, tarefa);
                _context.SaveChanges();
                return NoContent();
            }

            [HttpDelete("{id}")]
            public IActionResult DeletaTarefa(int id)
            {
                Tarefa tarefa = _context.Tarefas.FirstOrDefault(tarefa => tarefa.Id.Equals(id));
                if (tarefa == null)
                {
                    return NotFound();
                }
                _context.Remove(tarefa);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
