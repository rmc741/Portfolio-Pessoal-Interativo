using Application.CQRS.Commands;
using Application.DTOs;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Interface.Repository;
using Microsoft.Extensions.Logging;

namespace Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly ILogger<ProjectService> _logger;
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IMapper mapper,
            ILogger<ProjectService> logger,
            IProjectRepository projectRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _projectRepository = projectRepository;
        }

        public async Task<ProjectDTO> CreateNewProject(ProjectCreateCommand request)
        {
            var projectDTO = _mapper.Map<ProjectDTO>(request);
            var project = _mapper.Map<Project>(projectDTO);
            var newProject = _mapper.Map<ProjectDTO>(await _projectRepository.CreateNewProjectAsync(project));
            return newProject;
        }

        public async Task<List<ProjectDTO>> GetAllProjectsAsync()
        {
            var projetos = await _projectRepository.GetProjectsAsync();

            throw new NotImplementedException("Não implementado serviço para buscar projetos");
        }

        public Task<ProjectDTO> GetProjectByIdAsync(Guid id)
        {
            throw new NotImplementedException("Função para buscar por id ainda não implementado");
        }

        public Task<ProjectDTO> UpdateProjectAsync(Guid id, ProjectUpdateCommand request)
        {
            throw new NotImplementedException("Função para editar projeto por id ainda não implementado");
        }

        public Task DeleteProjectAsync(Guid id)
        {
            throw new NotImplementedException("Função para remover projeto ainda n implementado");
        }
    }
}
