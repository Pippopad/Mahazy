CREATE TABLE Recensione
(
	IdRecensione INT PRIMARY KEY IDENTITY,
	IdUtente INT FOREIGN KEY REFERENCES Utente(IdUtente),
	IdProdotto INT FOREIGN KEY REFERENCES Prodotto(IdProdotto),
	Contenuto TEXT NOT NULL, 
	NumeroStelle INT NOT NULL
)