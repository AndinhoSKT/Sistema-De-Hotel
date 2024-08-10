using System.Runtime.CompilerServices;

namespace Sistema_De_Hotel.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public Pessoa(string nome, string sobrenome, string cpf) {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
        }      
    }
}