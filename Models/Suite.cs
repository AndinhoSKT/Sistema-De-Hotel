using System.Runtime.InteropServices.Marshalling;

namespace Sistema_De_Hotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        
        public Suite(string tipoSuite) {
            TipoSuite = tipoSuite;
            TipoDeSuite();

        }

       public void TipoDeSuite() {
        if (TipoSuite == "Comun") {
            Capacidade = 1;
            ValorDiaria = 70.00m;
        } 
        else if (TipoSuite == "Plus") {
            Capacidade = 2;
            ValorDiaria = 100.00m;
        }
        else if (TipoSuite == "Master") {
            Capacidade = 5;
            ValorDiaria = 300.00m;
        }       
        else {
            throw new ArgumentException("Tipo de suíte inválido.");
        }
       
       }
    }
}