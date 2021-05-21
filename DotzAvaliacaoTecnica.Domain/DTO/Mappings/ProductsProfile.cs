using AutoMapper;

namespace DotzAvaliacaoTecnica.Domain.DTO.Mappings
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<DTO.ProductsDTO, Entities.Products>()
                .ForMember(d => d.Id, dto => dto.UseDestinationValue())
                .ForMember(d => d.Available, dto => dto.MapFrom(x => x.Available))
                .ForMember(d => d.ProductName, dto => dto.MapFrom(x => x.ProductName))
                .ForMember(d => d.RescuePoints, dto => dto.MapFrom(x => x.RescuePoints));

            CreateMap<Entities.Products, DTO.ProductsDTO>()
                .ForMember(d => d.Available, dto => dto.MapFrom(x => x.Available))
                .ForMember(d => d.ProductName, dto => dto.MapFrom(x => x.ProductName))
                .ForMember(d => d.RescuePoints, dto => dto.MapFrom(x => x.RescuePoints));
        }
    }
}
