using AutoMapper;
using DotzAvaliacaoTecnica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotzAvaliacaoTecnica.Domain.DTO.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<DTO.UserDTO, Entities.User>()
                .ForMember(d => d.Id, dto => dto.UseDestinationValue())
                .ForMember(d => d.Points, dto => dto.Ignore())
                .ForMember(d => d.UserExtracts, dto => dto.Ignore())
                .ForMember(d => d.Address, dto => dto.Ignore())
                .ForMember(d => d.Name, dto => dto.MapFrom(x => x.Name))
                .ForMember(d => d.Email, dto => dto.MapFrom(x => x.Email))
                .ForMember(d => d.Password, dto => dto.MapFrom(x => x.Password))
                .ForMember(d => d.BirthDate, dto => dto.MapFrom(x => x.BirthDate));

            CreateMap<Entities.User, DTO.UserDTO>()
             .ForMember(d => d.Name, dto => dto.MapFrom(x => x.Name))
             .ForMember(d => d.Email, dto => dto.MapFrom(x => x.Email))
             .ForMember(d => d.Password, dto => dto.MapFrom(x => x.Password))
             .ForMember(d => d.BirthDate, dto => dto.MapFrom(x => x.BirthDate));

            
        }
    }
}
