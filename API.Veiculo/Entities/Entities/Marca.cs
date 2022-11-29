
namespace Entities.Entities
{
    public class Marca
    {
        public Marca(int marcaID, string nomeMarca, Carro carroID)
        {
            MarcaID = marcaID;
            NomeMarca = nomeMarca;
            this.carroID = carroID;
        }

        public int MarcaID { get; set; }
        public string NomeMarca { get; set; }
        public Carro carroID { get; set; }
    }
}
