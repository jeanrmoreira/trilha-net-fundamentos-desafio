using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaParaEstacionamento.Models
{
    public class Estacionamento
    {
        private List<string> lista = new List<string>();
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        public Estacionamento()
        {
            Console.WriteLine("Seja bem vindo ao sitema de estacionamento!");
            Console.WriteLine("\nDigite o preço inicial: ");
            precoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nDigite o preço por hora: ");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());




        }


        public void adicionarVeiculo() {
            Console.WriteLine("\nDigite a placa do veículo: ");
            string veiculo = Console.ReadLine();
            lista.Add(veiculo);
        }

        public void listarVeiculos(){
            Console.WriteLine("\nVeículos estacionados:");
            int contador = 1;
            foreach (string item in lista)
            {
                Console.WriteLine($"{contador} - {item}");
                contador++;
                
            }
            if(lista.Count==0){
                Console.WriteLine("\n Não há veículos estacionados.");

            }
        }

        public void removerVeículos(){
            Console.WriteLine("\nDigite o veículo a remover:");
            string remover = Console.ReadLine();
            bool encontrado = false;

            for(int i = 0; i < lista.Count; i++){
                if (lista[i] == remover){
                    encontrado = true;
                    lista.RemoveAt(i);
                    Console.WriteLine("\nDigite quantas horas o veículo ficou estacionado:");
                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal precoTotal = precoInicial + precoPorHora * horas;
                    Console.WriteLine($"\nO veículo {remover} foi removido e o preço total foi de: R${precoTotal}");
                    break;
                }       
            }
            if(encontrado == false) {
                    Console.WriteLine("\nVeículo não encontrado!");
                }

            
            


        }
    }
}