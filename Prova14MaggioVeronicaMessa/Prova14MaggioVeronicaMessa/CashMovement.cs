using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova14MaggioVeronicaMessa
{
    public class CashMovement : IMovement
    {
        public string Esecutore { get; set; }
        public decimal Importo { get; set; }
        public DateTime DataDelMovimento { get; set; }

        public CashMovement(string esecutore, decimal importo, DateTime dataMovimento)
        {
            this.Esecutore = esecutore;

        }

        public override string ToString()
        {
            return $"Esecutore: {Esecutore}, Importo: {Importo}, Data del Movimento: {DataDelMovimento}";
        }
    }
}
