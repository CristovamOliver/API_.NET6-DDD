
namespace Entities.Entities
{
    public class Usuario
    {
        public Usuario(int usuarioID, string nome, string sexo, string dataNascimento, int idade, string email)
        {
            UsuarioID = usuarioID;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Idade = idade;
            Email = email;

       }

        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }


    }
}
