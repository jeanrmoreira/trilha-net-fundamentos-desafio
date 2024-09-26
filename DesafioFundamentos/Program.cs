// See https://aka.ms/new-console-template for more information
using SistemaParaEstacionamento.Models;

List<String> lista = new List<String>();
Estacionamento est = new Estacionamento();

string opcao;

while(true){
    Console.WriteLine("\nDigite sua opção: \n");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Sair\n");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            est.adicionarVeiculo();
            break;


        case "2":
            est.removerVeículos();
            break;

        case "3":
            est.listarVeiculos();
            break;
        
        case "4":
            Environment.Exit(0);
            break;
    }




}
