using Application.DTOs;
using Application.Interfaces;

namespace Application.Handlers
{
    public class ProjectHandler : IProjectHandler
    {
        public Task<ProjectDTO> CreateNewProjectHandler(ProjectDTO projectDTO)
        {
            throw new NotImplementedException("Criação de projeto ainda não implementada!!");
        }

        public Task DeleteProjectHandler(Guid id)
        {
            throw new NotImplementedException("Função ainda não implementada!");
        }

        public Task<List<ProjectDTO>> GetAllProjectsHandler()
        {
            throw new NotImplementedException("Função ainda não implementada!");
        }

        public Task<ProjectDTO> GetProjectHandler(Guid id)
        {
            throw new NotImplementedException("Função ainda não implementada!");
        }

        public Task<ProjectDTO> UpdateProjectHandler(Guid id, ProjectDTO projectDTO)
        {
            throw new NotImplementedException("Função ainda não implementada!");
        }
    }
}
