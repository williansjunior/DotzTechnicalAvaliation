using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Enums;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Services
{
    public interface IProductsService
    {
        Products AddProducts(Products products);

        List<Products> GetProductsAvailableToRescue();

        Products GetById(int id);
    }
}
