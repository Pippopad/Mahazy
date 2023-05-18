using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahazy.Models
{
    public class Prodotto
    {
        public int IdProdotto { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public float Prezzo { get; set; }
        public int Quantita { get; set; }

    }
}
