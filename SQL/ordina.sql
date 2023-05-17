CREATE TABLE Ordina
(
	IdUtente INT FOREIGN KEY REFERENCES Utente(IdUtente),
	IdProdotto INT FOREIGN KEY REFERENCES Prodotto(IdProdotto)
)