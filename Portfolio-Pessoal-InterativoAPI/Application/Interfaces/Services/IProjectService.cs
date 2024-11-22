using Application.DTOs;

namespace Application.Interfaces.Services
{
    public interface IProjectService
    {
        Task<List<ProjectDTO>> GetAllProjectsAsync();
        Task<ProjectDTO> GetProjectByIdAsync(Guid id);
        Task<ProjectDTO> CreateNewProject(ProjectDTO projectDTO);
        Task<ProjectDTO> UpdateProjectAsync(Guid id, ProjectDTO projectDTO);
        Task DeleteProjectAsync(Guid id);
    }
}
