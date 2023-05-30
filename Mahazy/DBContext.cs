using Dapper;
using Mahazy.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahazy
{
    public class DBContext
    {
        private SqlConnection db;

        public DBContext(string connectionString)
        {
            this.db = new SqlConnection(connectionString);
        }

        // Utente
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

        // Prodotto
        public List<Prodotto> GetProdottiAvailable()
        {
            var productDict = new Dictionary<int, Prodotto>();
            var products = db.Query<Prodotto, Utente, Prodotto>("SELECT * FROM Prodotto P INNER JOIN Utente U ON P.IdUtente = U.IdUtente WHERE P.Quantita > 0", (product, user) =>
            {
                if (!productDict.TryGetValue(product.IdProdotto, out var productEntry))
                {
                    productEntry = product;
                    productEntry.Venditore = user;
                    productDict.Add(productEntry.IdProdotto, productEntry);
                }

                return productEntry;
            }, splitOn: "IdUtente");

            return products.ToList();
        }

        public void AddProdotto(Prodotto p)
        {
            db.Execute("INSERT INTO Prodotto(Nome, Descrizione, Prezzo, IdUtente, Quantita) VALUES (@Nome, @Descrizione, @Prezzo, @IdUtente, @Quantita)", p);
        }

        public void RemoveProdotto(Prodotto p)
        {
            db.Execute("DELETE FROM Prodotto WHERE IdProdotto=@IdProdotto", p);
        }

        // Recensione
        public void AddRecensione(Recensione r)
        {
            db.Execute("INSERT INTO Recensione(IdUtente, IdProdotto, Contenuto, NumeroStelle) VALUES (@IdUtente, @IdProdotto, @Contenuto, @NumeroStelle)", r);
        }

        public List<Recensione> GetRecensioni(Prodotto p)
        {
            var reviews = db.Query<Recensione, Utente, Prodotto, Recensione>("SELECT * FROM Recensione R INNER JOIN Utente U ON R.IdUtente = U.IdUtente INNER JOIN Prodotto P ON R.IdProdotto = P.IdProdotto WHERE P.IdProdotto=@IdProdotto ORDER BY IdRecensione DESC", (review, user, product) =>
            {
                review.Autore = user;
                review.Prodotto = product;
                return review;
            }, p, splitOn: "IdUtente,IdProdotto");

            return reviews.ToList();
        }

        public void UpdateProdotto(Prodotto p)
        {
            db.Execute("UPDATE Prodotto SET Nome=@Nome, Descrizione=@Descrizione, Prezzo=@Prezzo, IdUtente=@IdUtente, Quantita=@Quantita WHERE IdProdotto=@IdProdotto", p);
        }

        public void RemoveRecensione(Recensione r)
        {
            db.Execute("DELETE FROM Recensione WHERE IdRecensione=@IdRecensione", r);
        }

        // Ordina
        public List<Ordina> GetOrders(Utente u)
        {
            var orders = db.Query<Ordina, Utente, Prodotto, Ordina>("SELECT * FROM Ordina O INNER JOIN Utente U ON O.IdUtente = U.IdUtente INNER JOIN Prodotto P ON O.IdProdotto = P.IdProdotto WHERE O.IdUtente=@IdUtente ORDER BY IdOrdine DESC", (order, user, product) =>
            {
                order.Utente = user;
                order.Prodotto = product;
                return order;
            }, u, splitOn: "IdUtente,IdProdotto");

            return orders.ToList();
        }

        public void AddOrdine(Ordina o)
        {
            db.Execute("INSERT INTO Ordina(IdUtente, IdProdotto) VALUES (@IdUtente, @IdProdotto)", o);
        }
    }
}
