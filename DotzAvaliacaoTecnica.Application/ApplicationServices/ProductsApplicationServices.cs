using AutoMapper;
using DotzAvaliacaoTecnica.Application.Interfaces;
using DotzAvaliacaoTecnica.Domain.DTO;
using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Enums;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotzAvaliacaoTecnica.Application.ApplicationServices
{
    public class ProductsApplicationServices : BaseApplicationService, IProductsApplicationService
    {
        private readonly IProductsService _service;
        public ProductsApplicationServices(IUnitOfWork uow,
            IProductsService service) : base(uow)
        {
            _service = service;
        }

        public ProductsDTO AddProducts(ProductsDTO productsDTO)
        {
            var product = Mapper.Map<Products>(productsDTO);
            var result = _service.AddProducts(product);

            Commit();

            return Mapper.Map(result, new ProductsDTO());
        }

        public ProductsDTO GetById(int id)
        {
            var products = _service.GetById(id);

            return Mapper.Map(products, new ProductsDTO());
        }

        public List<ProductsDTO> GetProductsAvailableToRescue()
        {
            var products = _service.GetProductsAvailableToRescue();

            return Mapper.Map(products, new List<ProductsDTO>());
        }
    }
}
