using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class CarroDTO
    {
        public int? CarroID { get; set;}
        [Required(ErrorMessage = "O nome da marca é obrigaório")]
        public string Modelo { get; set;}
        public int Ano { get; set; }
        public string Cor { get; set; }
        public int KM { get; set; }
        public virtual UsuarioDTO? UsuarioID { get; set; }


    }
}
