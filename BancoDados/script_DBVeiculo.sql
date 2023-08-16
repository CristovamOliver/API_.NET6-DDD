--DROP DATABASE Veiculo;

CREATE DATABASE Veiculo;


USE Veiculo;


CREATE TABLE USUARIO(
	UsuarioID INT NOT NULL IDENTITY PRIMARY KEY,
	Nome VARCHAR(40),
	Sexo CHAR(1),
	DataNascimento CHAR(10),
	Idade TINYINT,
	Email VARCHAR(35)

);

CREATE TABLE CARRO(
	CarroID INT NOT NULL IDENTITY PRIMARY KEY,	
	Modelo CHAR(15),
	Ano SMALLINT,
	Cor CHAR(25),
	KM INT,
	FOREIGN KEY (CarroID) REFERENCES USUARIO(UsuarioID) 

);


CREATE TABLE MARCA(
	MarcaID INT NOT NULL IDENTITY PRIMARY KEY,
	NomeMarca CHAR(15),
	FOREIGN KEY (MarcaID) REFERENCES CARRO(CarroID) 

	
);
