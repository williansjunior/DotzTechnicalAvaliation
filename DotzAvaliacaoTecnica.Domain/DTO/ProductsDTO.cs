using DotzAvaliacaoTecnica.Domain.Enums;

namespace DotzAvaliacaoTecnica.Domain.DTO
{
    public class ProductsDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int RescuePoints { get; set; }
        public ProductsAvailableRescueEnum Available { get; set; }
    }
}
