using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class UsuarioDTO
    {
        public UsuarioDTO(int UsuarioID, string UsuarioName)
        {
            UsuarioID = UsuarioID;
            UsuarioName = UsuarioName;

        }
        public int UsuarioID { get; set; }
        [Required(ErrorMessage = "Nome de usuário é obrigatório !")]
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
    }
}


