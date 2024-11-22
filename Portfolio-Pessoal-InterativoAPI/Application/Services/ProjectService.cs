using Application.DTOs;
using Application.Interfaces.Services;

namespace Application.Services
{
    public class ProjectService : IProjectService
    {
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
