using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Enums;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotzAvaliacaoTecnica.Domain.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _repo;

        public ProductsService(IUnitOfWork uow)
        {
            _repo = uow.ProductsRepository;
        }
        public Products AddProducts(Products products)
        {
             _repo.Add(products);

            return products;
        }

        public Products GetById(int id)
        {
            return _repo.Get(id);
        }

        public List<Products> GetProductsAvailableToRescue()
        {
            return _repo.Find(p => p.Available == (int)ProductsAvailableRescueEnum.Available).ToList();
        }
    }
}
