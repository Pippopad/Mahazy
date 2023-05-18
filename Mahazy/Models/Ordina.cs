using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahazy.Models
{
    public class Ordina
    {
        public int IdOrdine { get; set; }
        public Utente IdUtente { get; set; }
        public Prodotto IdProdotto { get; set; }
    }
}
