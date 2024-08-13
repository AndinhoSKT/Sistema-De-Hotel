using Sistema_De_Hotel.Models;
using System;

namespace Sistema_De_Hotel.Models
{
    public class Reserva 
    { 
        public int DiasReservados { get; set; }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }

        public Reserva() {
            Hospedes = new List<Pessoa>();
         }
        public Reserva(Suite suite, int diasReservados) : this() {         
            Suite = suite;
            DiasReservados = diasReservados;
        }

        public void CadastrarHospede(Pessoa hospede) {
            if (Hospedes.Count < Suite.Capacidade)
            {
                Hospedes.Add(hospede);
            }
            else
            {
                throw new Exception("Capacidade máxima da suíte atingida.");
            }
        }
        public void AdicionarHospede() {
            Console.WriteLine("Informe seu Nome: ");
            string nomeHospede = Console.ReadLine();
            Console.WriteLine("Informa seu Sobrenome: ");
            string sobrenomeHospede = Console.ReadLine();
            Console.WriteLine("Informe seu CPF: ");
            string cpfHospede = Console.ReadLine();
     
           Pessoa hospede = new Pessoa(nomeHospede, sobrenomeHospede, cpfHospede);
           //reserva.Hospedes.Add(hospede);

           try
        {
            CadastrarHospede(hospede); 
            Console.WriteLine("Hóspede cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        }

        public static Reserva CadastrarSuite() {
            Console.WriteLine("Informe o tipo de suite:");
            Console.WriteLine("Comun: Capacidade de 1 pessoa.");
            Console.WriteLine("Plus: Capacidade de 2 pessoas.");
            Console.WriteLine("Master: Capacidade de até 5 pessoas.");
            string hospedeSuite = Console.ReadLine();
           
            if (string.IsNullOrWhiteSpace(hospedeSuite)) {
                throw new Exception("Informe um tipo de Suite válido.");
            }
           
            Console.WriteLine("Informe a quantidades de dias que você deseja ficar:");
            string input = Console.ReadLine();
            int diasReservados;
            bool conversaoSucesso = int.TryParse(input, out diasReservados);
            if (!conversaoSucesso || diasReservados <= 0) {
            throw new Exception("Escolha um número de dias válido.");
            }

           Suite suite = new Suite(hospedeSuite);
           Reserva reserva = new Reserva(suite, diasReservados);
           Console.WriteLine("Suíte cadastrada com sucesso!");

           return reserva;
        }
        public int ObterQuantidadeHospedes() {
           return Hospedes.Count;
        }

        public decimal CalcularValorDiaria() {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10) {
                valorTotal *= 0.90m;
            }
            
            return valorTotal; 
            
        }

    }
}