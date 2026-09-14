using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Azure_API.Model
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Ramal { get; set; }
        public string EmailProfissional { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissão { get; set; }
    }
}