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

            CreateMap<ProjectCreateCommand, ProjectDTO>().ReverseMap();
            CreateMap<ProjectUpdateCommand, ProjectDTO>().ReverseMap();
        }
    }
}
