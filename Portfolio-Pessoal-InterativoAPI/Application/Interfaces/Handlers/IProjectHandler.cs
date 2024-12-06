using Application.CQRS.Commands;
using Application.DTOs;

namespace Application.Interfaces.Handlers
{
    public interface IProjectHandler
    {
        Task<ProjectDTO> CreateNewProjectHandler(ProjectCreateCommand projectDTO);
        Task<ProjectDTO> UpdateProjectHandler(ProjectUpdateCommand projectDTO);
        Task DeleteProjectHandler(Guid id);
        Task<ProjectDTO> GetProjectHandler(Guid id);
        Task<List<ProjectDTO>> GetAllProjectsHandler();
        Task<ProjectDTO> GetProjectWithCommentsHandler(Guid projectId);
    }
}
