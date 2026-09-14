using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Test_Azure_API.Context;
using Test_Azure_API.Model;

namespace Test_Azure_API.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController
    {
        private readonly ContextDataBase _context;
        private readonly ILogger<FuncionarioController> _logger;

        public FuncionarioController(ContextDataBase context, ILogger<FuncionarioController> log)
        {
            _context = context;
            _logger = log;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);

            _logger.LogInformation($"Funcionario {id} foi buscado no momento: {DateTime.Now}");

            if(funcionario == null)
                return NotFound();

            return Ok(funcionario);
        }

        [HttpPut]
        public IActionResult Criar(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();

            _logger.LogInformation($"Funcionario {id} foi adicionado no momento: {DateTime.Now}");

            return CreatedAtAction(nameof(ObeterPorId), new {id = funcionario.Id}, funcionario);
        }

        [HttpPost]
        public IActionResult Atualizar(int id, Funcionario funcionario)
        {
            var funcDb = _context.Funcionarios.Find(id);

            _logger.LogInformation($"Funcionario {id} foi atualizado no momento: {DateTime.Now}");

            if (funcDb == null)
                return NotFound();
            
            funcDb.Nome = funcionario.Nome;
            funcDb.Endereco = funcionario.Endereco;
            funcDb.Ramal = funcionario.Ramal;
            funcDb.EmailProfissional = funcionario.EmailProfissional;
            funcDb.Salario = funcionario.Salario;
            funcDb.DataAdmissão = funcionario.DataAdmissão;

            _context.Funcionarios.Update(funcDb);
            _context.SaveChanges();

            return Ok(funcDb);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);

            if (funcionario == null)
                return NotFound();

            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();

            return NoContent();
        }
    }
}