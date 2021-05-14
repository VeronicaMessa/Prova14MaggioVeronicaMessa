using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova14MaggioVeronicaMessa
{
   public interface IMovement
    {
        public decimal Importo { get; set; }
        public DateTime DataDelMovimento { get; set; }
      
    }
}
