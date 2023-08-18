using Dapper;
using Domain.Interfaces.IRepositories;
using Entities.Entities;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;

namespace Infrastructure.Repositories
{
    public class CarroRepository : Context, ICarroRepository
    {
        #region [Querys]

        private string atualizarCarro = @"UPDATE 
	                                            Carro
                                            SET
	                                            Modelo = @Modelo,
                                                Marca = @Marca,
                                                Ano = @Ano,
                                                Cor = @Cor,
                                                KM = @KM
                                            WHERE
	                                            CarroID = @CarroID";

        private string cadastrarCarro = @"INSERT INTO Carro
	                                                        (Modelo, Marca, Ano, Cor, KM)
                                                        VALUES
	                                                        (@Modelo, @Marca, @Ano, @Cor, @KM)";

        private string excluirCarro = @"DELETE FROM
	                                            Carro
                                            WHERE
	                                            CarroID = @CarroID";


        private string buscarCarro = @"SELECT 
	                                        * 
                                        FROM 
	                                        Carro(nolock)
                                        WHERE
	                                        CarroID = @CarroID";


        private string buscarCarros = @"SELECT * FROM  CARRO WITH (NOLOCK);";
        #endregion


        private string connection;
        public CarroRepository(IConfiguration configuration) : base(configuration)
        {
            connection = this.GetConnection();
        }

        public async Task<bool> AtualizarCarro(Carro carro)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var carroAtualizado = await con.ExecuteAsync(atualizarCarro, new
                    {
                        CarroID = carro.CarroID,
                        Modelo = carro.Modelo,
                        Marca = carro.Marca,
                        Ano = carro.Ano,
                        Cor = carro.Cor,
                        KM = carro.KM

                    });
                    if (carroAtualizado == 1)
                        return true;
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CadastrarCarro(Carro carro)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var carroCadastrado = await con.ExecuteAsync(cadastrarCarro, new
                    {
                        Modelo = carro.Modelo,
                        Marca = carro.Marca,
                        Ano = carro.Ano,
                        Cor = carro.Cor,
                        KM = carro.KM

                    });
                    if (carroCadastrado == 1)
                        return true;
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<List<Carro>> CarroEspecifico(int carroId)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var carro = await con.QueryAsync<Carro>(buscarCarro, new { carroID = carroId });
                    if (carro.Any())
                        return carro.ToList();
                    return new List<Carro>();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExcluirCarro(int carroId)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var carroExcluido = await con.ExecuteAsync(excluirCarro, new { carroID = carroId });

                    if (carroExcluido == 1)
                        return true;
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<List<Carro>> SelecionarCarros()
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var selecionaCarros = await con.QueryAsync<Carro>(buscarCarros);
                    if (selecionaCarros.Any())
                        return selecionaCarros.ToList();
                    return new List<Carro>();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

