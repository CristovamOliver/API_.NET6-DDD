using Dapper;
using Domain.Interfaces.IRepositories;
using Entities.Entities;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories
{
    public class MarcaRepository : Context, IMarcaRepository
    {
        #region [Querys]
        private string atualizaMarca = @"UPDATE 
	                                            Marca
                                            SET
	                                            nomeMarca = @nomeMarca,
                                            WHERE
	                                            CarroID = @CarroID";

        private string cadastrarMarca = @"INSERT INTO Marca
	                                                        (nomeMarca)
                                                        VALUES
	                                                        (@nomeMarca)";

        private string excluirMarca = @"DELETE FROM
	                                            Marca
                                            WHERE
	                                            CarroID = @CarroID";


        private string buscarMarca = @"SELECT 
	                                        * 
                                        FROM 
	                                        Marca(nolock)
                                        WHERE
	                                        CarroID = @CarroID";


        private string buscarMarcas = @"SELECT * FROM  Marca WITH (NOLOCK);";
        #endregion

        private string connection;
        public MarcaRepository(IConfiguration configuration) : base(configuration)
        {
            connection = this.GetConnection();
        }
        public async Task<bool> AtualizarMarca(Marca marca)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var marcaAtualizada = await con.ExecuteAsync(atualizaMarca, new
                    {
                        nomeMarca = marca.NomeMarca
                    });
                    var linhasAfetadas = con.Execute(atualizaMarca, marcaAtualizada);
                    if (linhasAfetadas > 0)
                        return true;
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<Marca> BuscarMarca(int marcaId)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var marca = await con.QuerySingleAsync<Marca>(buscarMarca, new { MarcaID = marcaId });
                    if (marca.MarcaID == 0)
                        return new Marca();
                    return marca;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<List<Marca>> BuscarMarcas()
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var marcas = await con.QueryAsync<Marca>(buscarMarcas);
                    if (marcas.Any())
                        return marcas.ToList();
                    return new List<Marca>();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CadastrarMarca(Marca marca)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var marcaCadastrada = await con.ExecuteAsync(cadastrarMarca, new
                    {
                        nomeMarca = marca.NomeMarca
                    });
                    var linhasAfetadas = con.Execute(atualizaMarca, marcaCadastrada);
                    if (linhasAfetadas > 0)
                        return true;
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExcluirMarca(int marcaId)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var marcaExcluida = await con.ExecuteAsync(excluirMarca, new { MarcaID = marcaId });

                    if (marcaExcluida == 1)
                        return true;
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}