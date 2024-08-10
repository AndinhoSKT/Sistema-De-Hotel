using Sistema_De_Hotel.Models;

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

        public void CadastrarHospedes() {
            Console.WriteLine("Informe seu Nome: ");
            string nomeHospede = Console.ReadLine();
            Console.WriteLine("Informa seu Sobrenome: ");
            string sobrenomeHospede = Console.ReadLine();
            Console.WriteLine("Informe seu CPF: ");
            string cpfHospede = Console.ReadLine();
     
           Pessoa novaPessoa = new Pessoa(nomeHospede, sobrenomeHospede, cpfHospede);
           Hospedes.Add(novaPessoa);

        }

        public void CadastrarSuite(Suite suite) {
            Console.WriteLine("Informe o tipo de suite:");
            Console.WriteLine("Comun: Capacidade de 1 pessoa.");
            Console.WriteLine("Plus: Capacidade de 2 pessoas.");
            Console.WriteLine("Master: Capacidade de até 5 pessoas.");
            string hospedeSuite = Console.ReadLine();
           
            if (string.IsNullOrWhiteSpace(hospedeSuite)) {
                throw new Exception("Informe um tipo de Suite válido.");
            }
            //if (hospedeSuite != "Comun" && hospedeSuite != "Plus" && hospedeSuite != "Master") {
           //     throw new Exception("Tipo de Suite inválida. Escolha entre 'Comun', 'Plus' ou 'Master'.");
           // }

            Console.WriteLine("Informe a quantidades de dias que você deseja ficar:");
            string input = Console.ReadLine();
            int diasReservados;
            bool conversaoSucesso = int.TryParse(input, out diasReservados);
            if (!conversaoSucesso || diasReservados <= 0) {
            throw new Exception("Escolha um número de dias válido.");
            }

           Suite = new Suite(hospedeSuite);
           Console.WriteLine("Suíte cadastrada com sucesso!");
        }
        public int ObterQuantidadeHospedes() {
           return Hospedes.Count;
        }

        public decimal CalcularValorDiaria() {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10) {
                valorTotal *= 0.5m;
            }
            
            return valorTotal; 
            
        }

        

    }
}