CREATE TABLE Users(
	Id INT IDENTITY PRIMARY KEY,
	Username VARCHAR(255) NOT NULL,
	Password VARCHAR(255) NOT NULL
)

INSERT INTO TABLE Users VALUES ('User','')

CREATE TABLE Funcionarios(
	Id INT IDENTITY PRIMARY KEY,
	Nome VARCHAR(255) NOT NULL,
	Setor VARCHAR(255) NOT NULL
)