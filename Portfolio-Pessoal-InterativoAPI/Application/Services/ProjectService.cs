using Application.DTOs;
using Application.Interfaces.Services;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly ILogger<ProjectService> _logger;
        //private readonly IProjectRepository _projectRepository;

        public ProjectService(IMapper mapper, ILogger<ProjectService> logger)
        {
            _mapper = mapper;
            _logger = logger;
        }

        //fazer o mapeamento aqui e as chamadas das funções do repository
        public Task<ProjectDTO> CreateNewProject(ProjectDTO projectDTO)
        {
            throw new NotImplementedException("Não implementado serviço para criar projeto");
        }

        public Task<List<ProjectDTO>> GetAllProjectsAsync()
        {
            throw new NotImplementedException("Função para pegar todos os projetos ainda não implementado");
        }

        public Task<ProjectDTO> GetProjectByIdAsync(Guid id)
        {
            throw new NotImplementedException("Função para buscar por id ainda não implementado");
        }

        public Task<ProjectDTO> UpdateProjectAsync(Guid id, ProjectDTO projectDTO)
        {
            throw new NotImplementedException("Função para editar projeto por id ainda não implementado");
        }

        public Task DeleteProjectAsync(Guid id)
        {
            throw new NotImplementedException("Função para remover projeto ainda n implementado");
        }
    }
}
