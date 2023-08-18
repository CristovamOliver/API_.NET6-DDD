
namespace Entities.Entities
{
    public class Carro
    {
        public int CarroID { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public int KM { get; set; }
        public Usuario UsuarioID { get; set; }
    }
}
