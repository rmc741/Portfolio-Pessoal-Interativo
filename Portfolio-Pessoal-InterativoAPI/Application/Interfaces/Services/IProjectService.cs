using Application.CQRS.Commands;
using Application.DTOs;

namespace Application.Interfaces.Services
{
    public interface IProjectService
    {
        Task<List<ProjectDTO>> GetAllProjectsAsync();
        Task<ProjectDTO> GetProjectByIdAsync(Guid id);
        Task<ProjectDTO> CreateNewProject(ProjectCreateCommand projectDTO);
        Task<ProjectDTO> UpdateProjectAsync(ProjectUpdateCommand projectDTO);
        Task DeleteProjectAsync(Guid id);
    }
}
