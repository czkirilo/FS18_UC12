using System;
using Sistema_UC12;
using Sistema_UC12.Classes;

class Program
{
static void Main(string[] args)
{

Endereco enderecodoygor = new Endereco();
enderecodoygor.logradouro = "Rua Niteroi";
enderecodoygor.numero = 180;
enderecodoygor.complemento = "Escola Senai Paulo Skaf";
enderecodoygor.enderecoComercial = true;

//PessoaFisica novapf = new PessoaFisica();

//novapf.cpf = "4555555555";
//novapf.endereco = enderecodoygor;
//novapf.dataNascimento = new DateTime (2004, 01, 18);
//novapf.nome = "Ygor de Andrade";


//Console.WriteLine(novapf.endereco.logradouro);
//Console.WriteLine(novapf.endereco.numero);
//Console.WriteLine(novapf.endereco.complemento);
//Console.WriteLine(novapf.endereco.enderecoComercial);
//Console.WriteLine(novapf.nome);
//Console.WriteLine(novapf.dataNascimento);

//interpolação
//Console.WriteLine($"O endereço do {novapf.nome} é {novapf.endereco.logradouro}, numero {novapf.endereco.numero}");

//concatenação
//Console.WriteLine("O endereço do " + novapf.nome + " é " + novapf.endereco.logradouro + ", " + novapf.endereco.numero);

//bool idadevalidada = novapf.ValidarDataNascimento(novapf.dataNascimento);
//if (idadevalidada == true){
 //   Console.WriteLine($"Pode beber pinga");
//}else{
 //   Console.WriteLine($"Vai ficar só no refri");
//}

PessoaJuridica novapj = new PessoaJuridica();

novapj.endereco = enderecodoygor;
novapj.nome = "SENAI";
novapj.cnpj = "12345678990001";
novapj.razaoSocial = "Empresa Top";

if (novapj.ValidarCNPJ(novapj.cnpj)){
    Console.WriteLine("CNPJ VALIDO");
}else{
     Console.WriteLine("CNPJ INVALIDO");
}
}
}