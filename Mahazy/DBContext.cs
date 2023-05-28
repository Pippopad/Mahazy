﻿using Dapper;
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
        public List<Prodotto> GetProdotti()
        {
            var productDict = new Dictionary<int, Prodotto>();
            var products = db.Query<Prodotto, Utente, Prodotto>("SELECT * FROM Prodotto P INNER JOIN Utente U ON P.IdUtente = U.IdUtente", (product, user) =>
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
            //return db.Query<Prodotto>("SELECT * FROM Prodotto").ToList();
        }

        public void AddProdotto(Prodotto p)
        {
            db.Execute("INSERT INTO Prodotto(Nome, Descrizione, Prezzo, Venditore, Quantita) VALUES (@Nome, @Descrizione, @Prezzo, @Venditore, @Quantita)", p);
        }
    }
}