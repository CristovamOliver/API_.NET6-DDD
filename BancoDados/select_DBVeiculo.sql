

SELECT * FROM  USUARIO WITH (NOLOCK);
SELECT * FROM  CARRO WITH (NOLOCK);




-- SELECT GERAL;
SELECT * FROM USUARIO WITH (NOLOCK)
INNER JOIN CARRO on USUARIO.UsuarioID = CARRO.CarroID;
