using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_UC12.Classes
{
    public abstract class Pessoa
    {
        public string? nome { get; set; }

        public string? endereco { get; set; }

        public bool enderecoComercial { get; set; }

        public void PagarImposto(){}
    }
}