using Dapper;
using Mahazy.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahazy.DBContext
{
    public class DBUtente
    {
        private SqlConnection db;

        public DBUtente(string connectionString)
        {
            this.db = new SqlConnection(connectionString);
        }

        public List<Utente> GetUtenti()
        {
            return db.Query<Utente>("SELECT * FROM Utente").ToList();
        }

        public Utente GetUtente(Utente u)
        {
            return db.QueryFirstOrDefault<Utente>("SELECT * FROM Utente WHERE Username=@Username", u);
        }

        public void AddUtente(Utente u)
        {
            db.Execute("INSERT INTO Utente(Nome, Cognome, Username, Password) VALUES (@Nome, @Cognome, @Username, @Password)", u);
        }
    }
}
