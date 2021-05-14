using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova14MaggioVeronicaMessa
{
    public class Account<T>:IEnumerable<T>where T:IMovement
    {
        public int NumeroConto { get; set; }
        public string NomeBanca { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        private List<T> movimenti = new List<T>();



        public void Versa(T movimento)
        {
            this.movimenti.Add(movimento);
            Saldo += movimento.Importo;
            
        }
     
        //public static T operator +(T a)
        //{
        //    return a.
        //}
        public void  Preleva(T movimento)
        {
            this.movimenti.Add(movimento);
             Saldo -= movimento.Importo;
           
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var m in this.movimenti)
                yield return m;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return $"Numero conto: {NumeroConto}, Nome Banca: {NomeBanca}, Saldo: {Saldo}";
        }
        
    }
}
