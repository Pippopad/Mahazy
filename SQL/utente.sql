﻿CREATE TABLE Utente 
(
	IdUtente INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR (20) NOT NULL,
	Cognome VARCHAR (40) NOT NULL,
	Username VARCHAR (20) NOT NULL,
	Password VARCHAR (20) NOT NULL
)