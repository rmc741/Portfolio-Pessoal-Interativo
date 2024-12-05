using Application.CQRS.Commands;
using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<ProjectUpdateCommand, Project>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ProjectCreateCommand, Project>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()) // O ID pode ser gerado no banco
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow)) // Se necessário, defina o CreatedAt
                .ReverseMap();

            CreateMap<ProjectCreateCommand, ProjectDTO>().ReverseMap();
            CreateMap<ProjectUpdateCommand, ProjectDTO>().ReverseMap();
        }
    }
}
