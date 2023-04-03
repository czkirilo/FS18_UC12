using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Sistema_UC12.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string? cpf { get; set; }

        public string? rg { get; set; }

        public DateTime dataNascimento { get; set; }
    }
}