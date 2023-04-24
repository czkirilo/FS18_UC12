using System;
using Sistema_UC12;
using Sistema_UC12.Classes;

class Program
{
static void Main(string[] args)
{
    void BarraCarregamento(string textoCarregamento){
        Console.WriteLine(textoCarregamento);
        Thread.Sleep(500);

        for (var contador = 0; contador < 5; contador++){
            Console.Write("|");
            Thread.Sleep(500);
}
    }
    Console.Clear();
    
   // Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;


    Console.WriteLine(@$"


    (/◔ ◡ ◔)/
    ♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡
    ♡                                                                       ♡  
    ♡  Seja Bem vindo ao sistema de cadastro de pessoa física e jurídica    ♡
    ♡                                                                       ♡
    ♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡
    
 ");

BarraCarregamento("INICIANDO");

Console.Clear();

 string opcao;
do {
    Console.WriteLine(@$"

    ♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡
    ♡                                                                       ♡  
    ♡                     Escolha uma das opções abaixo                     ♡
    ♡                                                                       ♡
    ♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡
    ♡                                                                       ♡  
    ♡                       1 - Pessoa Física                               ♡
    ♡                       2 - Pessoa Juridica                             ♡
    ♡                                                                       ♡
    ♡                       0 - Sair                                        ♡
    ♡                                                                       ♡
    ♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡
    
 ");

  opcao = Console.ReadLine();

 switch (opcao)
 {
    case "1":
    Endereco enderecodoygor = new Endereco();
    enderecodoygor.logradouro = "Rua Niteroi";
    enderecodoygor.numero = 180;
    enderecodoygor.complemento = "Escola Senai Paulo Skaf";
    enderecodoygor.enderecoComercial = true;

    PessoaFisica novapf = new PessoaFisica();

    novapf.cpf = "4555555555";
    novapf.endereco = enderecodoygor;
    novapf.dataNascimento = new DateTime (2004, 01, 18);
    novapf.nome = "Ygor de Andrade";

    bool idadevalidada = novapf.ValidarDataNascimento(novapf.dataNascimento);
if (idadevalidada == true){
    Console.WriteLine($"Pode beber pinga");
}else{
    Console.WriteLine($"Vai ficar só no refri");
}

    Console.WriteLine($"O endereço do {novapf.nome} é {novapf.endereco.logradouro}, numero {novapf.endereco.numero}");

    break;
    case "2":
    Endereco endereconovo = new Endereco();
    endereconovo.logradouro = "Rua Niteroi";
    endereconovo.numero = 180;
    endereconovo.complemento = "Escola Senai Paulo Skaf";
    endereconovo.enderecoComercial = true;

    
    PessoaJuridica novapj = new PessoaJuridica();
    
novapj.endereco = endereconovo;
novapj.nome = "SENAI";
novapj.cnpj = "12345678990001";
novapj.razaoSocial = "Empresa Top";

if (novapj.ValidarCNPJ(novapj.cnpj)){
    Console.WriteLine("CNPJ VALIDO");
}else{
     Console.WriteLine("CNPJ INVALIDO");
}

Console.WriteLine($"O endereço do {novapj.nome} é {novapj.endereco.logradouro}, numero {novapj.endereco.numero}");

    break;
    case "0":
     Console.WriteLine("Obrigado por utilizar o nosso sistema");
    BarraCarregamento("Finalizando");
    break;
    default:
    Console.WriteLine("Opção Invalida, digite uma das opções apresentadas");
    break;    
 }

}while (opcao != "0");

Console.ResetColor();



}
}