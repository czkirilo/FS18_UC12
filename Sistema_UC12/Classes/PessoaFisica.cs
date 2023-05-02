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

        public override double PagarImposto(float rendimento){
        //Para rendimentos até R$1.500,00 - isento (desconto 0)
        //Para rendimentos entre R$1.501,00 e R$5.000,00 - desconto de 3%
        //Para rendimentos acima de R$5.000,01 - desconto de 5%
        if (rendimento <= 1500){
                return 0;
        } else if (rendimento > 1500 && rendimento <= 5000){
                return (rendimento/100)*3;
        } else{
                return rendimento * 0.08;
        }

        }

        public bool ValidarDataNascimento(DateTime dataNasc){
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;


            if (anos >= 18){
                return true;
            }else{
                return false;
            }
        }
    }
}