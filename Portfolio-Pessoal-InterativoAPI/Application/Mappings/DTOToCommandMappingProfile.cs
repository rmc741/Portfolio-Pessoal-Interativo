using Application.CQRS.Commands;
using Application.DTOs;
using AutoMapper;

namespace Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProjectDTO, ProjectCreateCommand>();
            CreateMap<ProjectDTO, ProjectUpdateCommand>();
        }
    }
}
