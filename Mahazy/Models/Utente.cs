using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahazy.Models
{
    public class Utente
    {
        public int IdUtente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<Prodotto> Prodotti { get; set; }
    }
}
