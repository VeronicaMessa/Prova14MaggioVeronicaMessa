using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova14MaggioVeronicaMessa
{
    public enum Tipo
    {
        AMEX, 
        VISA, 
        MASTERCARD, 
        OTHER
    }
    public class CreditCardMovement : IMovement
    {
        public Tipo Tipologia { get; set; }
        public int NumeroCarta { get; set; }
        public decimal Importo { get;set; }
        public DateTime DataDelMovimento { get; set; }

        public CreditCardMovement( Tipo tipologia, int numeroCarta, decimal importo, DateTime dataMovimento)
        {
            this.Tipologia = tipologia;
            this.NumeroCarta = numeroCarta;
            this.Importo = importo;
            this.DataDelMovimento = dataMovimento;
        }
        public override string ToString()
        {
            return $"Tipologia carta: {Tipologia}, Numero carta: {NumeroCarta}, Importo: {Importo}, Data del movimento: {DataDelMovimento}";
        }
    }
}
