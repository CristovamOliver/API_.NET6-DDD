-- INSERT USUARIO

INSERT INTO USUARIO(Nome, Sexo, DataNascimento, Idade, Email)
VALUES('Lucas Oliveira', 'M', '22/02/1996', '26', 'contato.lucas55@gmail.com'),
('Kely Brenda', 'F', '19/07/1997', '25', 'kely-brenda@gmail.com'),
('Milena Guzman', 'F', '18/02/1999', '23', 'miestela-22@hotmail.com'),
('Luan Oliveira', 'M', '16/05/2000', '22', 'contato.luan55@hotmail.com'),
('Diego Guzman', 'M', '05/09/2003', '19', 'diego-guzman@hotmail.com'),
('Nicole Guzman', 'F', '09/02/2002', '20', 'contato.luan55@hotmail.com');



-- INSERT CARRO

INSERT INTO CARRO(Modelo, Ano, Cor, KM)
VALUES
('Corolla', '2007', 'Preto', 97357),
('Civic', '2022', 'Preto', 7111),
('HB20', '2016', 'Prata', 45989),
('Spin', '2018', 'Cinza', 11234),
('Sportage', '2014', 'Preto', 80792),
('Fusca', '1977', 'Amarelo', 592128);



-- INSERT MARCA

INSERT INTO MARCA(NomeMarca)
VALUES
('Toyota'),
('Honda'),
('Hyundai'),
('GM'),
('KIA'),
('VW');

-- ALTERAR COLUNA
UPDATE USUARIO SET DataNascimento = '18/02/1999'
WHERE UsuarioID = 3;

-- EXCLUIR TABELA
DROP TABLE CARRO;

-- EXCLUIR REGISTRO
DELETE FROM MARCA WHERE MarcaID = 2;

-- EXCLUIR VÁRIOS REGISTROS
DELETE FROM CARRO;
DELETE FROM MARCA;
DELETE FROM USUARIO;
