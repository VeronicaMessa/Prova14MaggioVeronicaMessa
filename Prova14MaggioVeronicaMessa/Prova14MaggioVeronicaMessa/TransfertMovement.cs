using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova14MaggioVeronicaMessa
{
    public class TransfertMovement : IMovement
    {
        public string BancaOrigine { get; set;}
        public string BancaDestinazione { get; set; }
        public decimal Importo { get;set; }
        public DateTime DataDelMovimento { get;set; }

        public TransfertMovement(string bancaOrigine, string bancaDestinazione, decimal importo, DateTime dataMovimento)
        {
            this.BancaOrigine = bancaOrigine;
            this.BancaDestinazione = bancaDestinazione;
        }
        public override string ToString()
        {
            return $"Banca origine: {BancaOrigine}, Banca destinazione: {BancaDestinazione}, Importo: {Importo}, Data del movimento: {DataDelMovimento}";
        }
    }
}
