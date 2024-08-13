using System.Collections.Generic;
using System.Linq;   
using Sistema_De_Hotel.Models; 
using System;

namespace Sistema_De_Hotel {
    class Program {
        static void Main(string[] args) {
        
        Reserva reserva = null;
        string opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao Sistema de Hotel!");
            Console.WriteLine("1 - Cadastrar Suíte");
            Console.WriteLine("2 - Adicionar Hóspede");
            Console.WriteLine("3 - Obter Quantidade de Hóspedes");
            Console.WriteLine("4 - Calcular Valor da Diária");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    reserva = Reserva.CadastrarSuite();
                    break;
                case "2":
                    if (reserva == null)
                    {
                        Console.WriteLine("Você precisa cadastrar uma suíte antes de adicionar hóspedes.");
                    }
                    else
                    {
                        reserva.AdicionarHospede();
                    }
                    break;
                case "3":
                    if (reserva != null)
                    {
                        Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma reserva foi feita.");
                    }
                    break;
                case "4":
                    if (reserva != null)
                    {
                        Console.WriteLine($"Valor total da diária: {reserva.CalcularValorDiaria():C}");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma reserva foi feita.");
                    }
                    break;
                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            if (opcao != "5")
            {
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != "5");
    

    }
    }          
  }


