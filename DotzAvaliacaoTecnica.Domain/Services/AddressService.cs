using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using DotzAvaliacaoTecnica.Domain.ValueObjects;

namespace DotzAvaliacaoTecnica.Domain.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _repo;
        public AddressService(IUnitOfWork uow)
        {
            _repo = uow.AddressRepository;
        }

        public Address AddUserAddress(Address address)
        {
            _repo.Add(address);

            return address;
        }

        public Address GetUserAddressByUserId(int userId)
        {
            return _repo.GetUserAddressByUserId(userId);
        }
    }
}
