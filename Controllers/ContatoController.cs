

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
        public IActionResult Lista()
        {
            return Ok(contatos);
        }   

        [HttpGet("{Id}")]
        public IActionResult BuscarId(int id)
        {
            var contato = contatos.FirstOrDefault(c => c.Id == id);

            if (contato == null)
                return NotFound();

            contatos.Remove(contato);

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
            var contatos = contato.FirstOrDefault(p => p.Id = id);

            if (contatos == null)
                return NotFound();

            contatos.Nome = contatosAtualizado.Nome;
            contatos.Telefone = contatosAtualizado.Telefone;
            contatos.Ativo = contatosAtualizado.Ativo;
            contatos.Id = contatosAtualizado.Id;
            return OK(contatos);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatos = contatos.FirstOrDefault(c => p.Id == id);

            if (contatos == null)
                return NotFound();

            contatos.Remove(contatos);
            return OK(contatos);

        }
    }
}