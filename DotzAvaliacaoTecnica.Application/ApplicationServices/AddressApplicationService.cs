using AutoMapper;
using DotzAvaliacaoTecnica.Application.Interfaces;
using DotzAvaliacaoTecnica.Domain.DTO;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using DotzAvaliacaoTecnica.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotzAvaliacaoTecnica.Application.ApplicationServices
{
    public class AddressApplicationService : BaseApplicationService, IAddressApplicationService
    {
        private readonly IAddressService _service;
        public AddressApplicationService(IUnitOfWork uow,
            IAddressService service) : base(uow)
        {
            _service = service;
        }

        public AddressDTO AddUserAddress(AddressDTO addressDTO)
        {
            var address = Mapper.Map<Address>(addressDTO);
            var result = _service.AddUserAddress(address);
            Commit();

            return Mapper.Map(result, new AddressDTO());
        }

        public AddressDTO GetUserAddressByUserId(int userId)
        {
            var userAddress = _service.GetUserAddressByUserId(userId);

            return Mapper.Map(userAddress, new AddressDTO());
        }
    }
}
