using Dapper;
using Domain.Interfaces.IRepositories;
using Entities.Entities;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository : Context, IUsuarioRepository
    {
        #region[Querys]
        private string atualizaUsuario = @"UPDATE 
	                                            Usuario
                                            SET
	                                            Nome = @Nome,
                                                Sexo = @Sexo,
                                                DataNascimento = @DataNascimento,
                                                Idade = @Idade,
                                                Email = @Email
            
                                            WHERE
	                                            UsuarioID = @UsuarioID";

        private string cadastraUsuario = @"INSERT INTO Usuario
	                                                        (Nome, Sexo, DataNascimento, Idade, Email)
                                                        VALUES
	                                                        (@Nome, @Sexo, @DataNascimento, @Idade, @Email)";

        private string excluirUsuario = @"DELETE FROM
	                                            Usuario
                                            WHERE
	                                            UsuarioID = @UsuarioID";


        private string buscarUsuario = @"SELECT 
	                                        * 
                                        FROM 
	                                        Usuario(nolock)
                                        WHERE
	                                        UsuarioID = @UsuarioID";


        private string buscarUsuarios = @"SELECT * FROM  Usuario WITH (NOLOCK);";
        #endregion
        private string connection;

        public UsuarioRepository(IConfiguration configuration) : base(configuration)
        {
            connection = this.GetConnection();
        }

        public async Task<bool> AtualizarUsuario(Usuario usuario)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var usuarioAtualizado = await con.ExecuteAsync(atualizaUsuario, new
                    {
                        UsuarioID = usuario.UsuarioID,
                        Nome = usuario.Nome,
                        Sexo = usuario.Sexo,
                        DataNascimento = usuario.DataNascimento,
                        Idade = usuario.Idade,
                        Email = usuario.Email,
                    });
                    if (usuarioAtualizado == 1)
                        return true;
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<List<Usuario>> BuscarUsuario(int UsuarioID)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var usuario = await con.QueryAsync<Usuario>(buscarUsuario, new { UsuarioID = UsuarioID });
                    if (usuario.Any())
                        return usuario.ToList();
                    return new List<Usuario>();

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<List<Usuario>> BuscarUsuarios()
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var usuarios = await con.QueryAsync<Usuario>(buscarUsuarios);
                    if (usuarios.Any())
                        return usuarios.ToList();
                    return new List<Usuario>();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CadastrarUsuario(Usuario usuario)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var usuarioCadastrado = await con.ExecuteAsync(cadastraUsuario, new
                    {
                        Nome = usuario.Nome,
                        Sexo = usuario.Sexo,
                        DataNascimento = usuario.DataNascimento,
                        Idade = usuario.Idade,
                        Email = usuario.Email

                    });
                    if (usuarioCadastrado == 1)
                        return true;
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExcluirUsuario(int usuarioId)
        {
            try
            {
                using (var con = new SqlConnection(connection))
                {
                    var usuarioExcluido = await con.ExecuteAsync(excluirUsuario, new { UsuarioID = usuarioId });

                    if (usuarioExcluido == 1)
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
