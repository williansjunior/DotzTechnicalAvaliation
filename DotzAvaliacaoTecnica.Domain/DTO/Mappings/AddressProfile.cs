using AutoMapper;

namespace DotzAvaliacaoTecnica.Domain.DTO.Mappings
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<DTO.AddressDTO, ValueObjects.Address>()
                .ForMember(d => d.Id, dto => dto.UseDestinationValue())
                .ForMember(d => d.State, dto => dto.MapFrom(x => x.State))
                .ForMember(d => d.Street, dto => dto.MapFrom(x => x.Street))
                .ForMember(d => d.City, dto => dto.MapFrom(x => x.City))
                .ForMember(d => d.Complement, dto => dto.MapFrom(x => x.Complement))
                .ForMember(d => d.Country, dto => dto.MapFrom(x => x.Country))
                .ForMember(d => d.ZipCode, dto => dto.MapFrom(x => x.ZipCode))
                .ForMember(d => d.Number, dto => dto.MapFrom(x => x.Number))
                .ForMember(d => d.District, dto => dto.MapFrom(x => x.District))
                .ForMember(d => d.UserId, dto => dto.MapFrom(x => x.UserId));

            CreateMap<ValueObjects.Address, DTO.AddressDTO>()
                .ForMember(d => d.State, dto => dto.MapFrom(x => x.State))
                .ForMember(d => d.Street, dto => dto.MapFrom(x => x.Street))
                .ForMember(d => d.City, dto => dto.MapFrom(x => x.City))
                .ForMember(d => d.Complement, dto => dto.MapFrom(x => x.Complement))
                .ForMember(d => d.Country, dto => dto.MapFrom(x => x.Country))
                .ForMember(d => d.ZipCode, dto => dto.MapFrom(x => x.ZipCode))
                .ForMember(d => d.Number, dto => dto.MapFrom(x => x.Number))
                .ForMember(d => d.District, dto => dto.MapFrom(x => x.District))
                .ForMember(d => d.UserId, dto => dto.MapFrom(x => x.UserId));
        }
    }
}
