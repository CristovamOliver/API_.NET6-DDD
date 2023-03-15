
namespace Entities.Entities
{
    public class Carro
    {
        //public Carro(int carroID, string modelo, int ano, string cor, int kM, Usuario usuarioID)
        //{
        //    CarroID = carroID;
        //    Modelo = modelo;
        //    Ano = ano;
        //    Cor = cor;
        //    KM = kM;
        //    UsuarioID = usuarioID;
        //}

        public int CarroID { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public int KM { get; set; }
        public Usuario UsuarioID { get; set; }
    }
}
