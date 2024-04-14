using AutoMapper;
using Cliente.CrossCutting.Commands;
using Cliente.Domain.DTOs;
using Cliente.Domain.Entities;

namespace Cliente.CrossCutting
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClienteDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Sexo, opt => opt.MapFrom(src => src.Sex))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.Telephone))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(dest => dest.Observacao, opt => opt.MapFrom(src => src.Observation));

            CreateMap<ClienteDTO, Client>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sexo))
                .ForMember(dest => dest.Telephone, opt => opt.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.DataNascimento))
                .ForMember(dest => dest.Observation, opt => opt.MapFrom(src => src.Observacao));

            CreateMap<CreateClienteCommand, Client>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sexo))
                .ForMember(dest => dest.Telephone, opt => opt.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.DataNascimento))
                .ForMember(dest => dest.Observation, opt => opt.MapFrom(src => src.Observacao));

            CreateMap<UpdateClienteCommand, Client>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sexo))
                .ForMember(dest => dest.Telephone, opt => opt.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.DataNascimento))
                .ForMember(dest => dest.Observation, opt => opt.MapFrom(src => src.Observacao));            
        }
    }
}
