using DotzAvaliacaoTecnica.Domain.DTO;
using DotzAvaliacaoTecnica.Domain.Enums;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Application.Interfaces
{
    public interface IProductsApplicationService
    {
        ProductsDTO AddProducts(ProductsDTO productsDTO);
        List<ProductsDTO> GetProductsAvailableToRescue();

        ProductsDTO GetById(int id);
    }
}
