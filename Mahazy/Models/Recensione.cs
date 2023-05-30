using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahazy.Models
{
    public class Recensione
    {
        public int IdRecensione { get; set; }
        public int IdUtente { get; set; }
        public int IdProdotto { get; set; }
        public string Contenuto { get; set; }
        public int NumeroStelle { get; set; }

        public Utente Autore { get; set; }
        public Prodotto Prodotto { get; set; }
    }
}
