

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Senai_11._06._2026.models;
using Microsoft.AspNetCore.Mvc;



namespace Senai_11._06._2026.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContatoController : ControllerBase
    {
        public static List<Contato> contatos = new List<Contato>
        {
          new Contato {Id=1, Nome="João Bento", Telefone="12246573", Ativo= true},
          new Contato {Id=2, Nome="Guilherme", Telefone="12345678910", Ativo= true},
          new Contato {Id=3, Nome="Leonardo", Telefone="10987654321", Ativo= false}
        };

        [HttpGet]
        public IActionResult Lista()
        {
            return Ok(contatos);
        }

        [HttpGet("{i    d}")]
        public IActionResult BuscarId(int id)
        {
            var contato = contatos.FirstOrDefault(c => c.Id == id);

            if (contato == null)
                return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult Cadastrar(Contato contato)
        {
            contatos.Add(contato);
            return Ok(contatos);
        }
        [HttpPut("{id}")]

        public IActionResult Atualizar(int id, Contato contatoAtualizado)
        {
            var contato = contatos.FirstOrDefault(p => p.Id == id);

            if (contato == null)
                return NotFound();

            contato.Nome = contatoAtualizado.Nome;
            contato.Telefone = contatoAtualizado.Telefone;
            contato.Ativo = contatoAtualizado.Ativo;
            contato.Id = contatoAtualizado.Id;
            return Ok(contato);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contato = contatos.FirstOrDefault(c => c.Id == id);

            if (contato == null)
                return NotFound();

            contatos.Remove(contato);
            return Ok(contatos);

        }
    }
}