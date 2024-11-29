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
            CreateMap<ProjectUpdateCommand, Project>().ReverseMap();

            CreateMap<ProjectCreateCommand, ProjectDTO>().ReverseMap();
            CreateMap<ProjectUpdateCommand, ProjectDTO>().ReverseMap();
        }
    }
}
