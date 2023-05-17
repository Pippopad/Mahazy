CREATE TABLE Recenzione
(
	IdUtente INT FOREIGN KEY REFERENCES Utente(IdUtente),
	IdProdotto INT FOREIGN KEY REFERENCES Prodotto(IdProdotto)
)