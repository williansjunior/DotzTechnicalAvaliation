using DotzAvaliacaoTecnica.Domain.DTO;

namespace DotzAvaliacaoTecnica.Application.Interfaces
{
    public interface IAddressApplicationService
    {
        AddressDTO AddUserAddress(AddressDTO addressDTO);
        AddressDTO GetUserAddressByUserId(int userId);
    }
}
