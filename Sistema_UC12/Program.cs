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

List<PessoaFisica> listaPf = new List<PessoaFisica>();
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
string? opcaoPF;
do{
Console.Clear();
Console.WriteLine(@$"

    ♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡
    ♡                                                                       ♡  
    ♡                     Escolha uma das opções abaixo                     ♡
    ♡                                                                       ♡
    ♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡
    ♡                                                                       ♡  
    ♡                       1 - Cadastrar Pessoa Física                     ♡
    ♡                       2 - Mostrar Pessoas Fisicas                     ♡
    ♡                                                                       ♡
    ♡                       0 - Voltar ao menu anterior                     ♡
    ♡                                                                       ♡
    ♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡♡
    
 ");
 opcaoPF = Console.ReadLine();

switch (opcaoPF){
    case "1":
    PessoaFisica novapf = new PessoaFisica();
    Endereco endereco = new Endereco();

    Console.WriteLine("Digite o logradouro da pessoa física que deseja cadastrar");
    endereco.logradouro = Console.ReadLine();

    Console.WriteLine("Digite o numero");
    endereco.numero = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o complemento");
    endereco.complemento = Console.ReadLine();
    
    Console.WriteLine("Se trata de um local comercial? S/N");
    string endCom = Console.ReadLine().ToUpper();

    if (endCom == "S"){
        endereco.enderecoComercial = true;
    }
    else{
        endereco.enderecoComercial = false;
    }

    Console.WriteLine("Digite o cpf");
    novapf.cpf = Console.ReadLine();

    novapf.endereco = endereco;

     Console.WriteLine("Digite A data de nascimento Ex: DD/MM/AAAA");
     novapf.dataNascimento = DateTime.Parse(Console.ReadLine());

          bool idadevalidada = novapf.ValidarDataNascimento(novapf.dataNascimento);
 if (idadevalidada == true){
     Console.WriteLine($"Pode beber pinga");
 }else{
     Console.WriteLine($"Vai ficar só no refri");
 }

      Console.WriteLine("Digite o nome da pessoa física que deseja cadastrar");
      novapf.nome = Console.ReadLine();

      listaPf.Add(novapf);
      Console.WriteLine("cadastro efetuado com sucesso");
      Thread.Sleep(4000);
        break;
    case "2":
    Console.Clear();
    if (listaPf.Count > 0){
        foreach(PessoaFisica cadaPessoa in listaPf){
            Console.Clear();
            Console.WriteLine(@$"
            Nome: {cadaPessoa.nome}
            Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
            Data de Nascimento: {cadaPessoa.dataNascimento}
            ");
        Console.WriteLine("Digite qualquer tecla para continuar");
        Console.ReadLine();
        }
    }else{
        Console.WriteLine("Lista Vazia!!! Digite qualquer tecla para continuar");
        Console.ReadLine();
    }
        break;
    case "0":
        break;
    default:
    Console.Clear();
    Console.WriteLine("Opção Inválida, por favor digite outra opção");
    Thread.Sleep(2000);
        break;
}

}while (opcaoPF != "0");

//     Console.WriteLine($"O endereço do {novapf.nome} é {novapf.endereco.logradouro}, numero {novapf.endereco.numero}");

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