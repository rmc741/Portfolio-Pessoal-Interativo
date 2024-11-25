using Application.CQRS.Commands;
using Application.DTOs;
using Application.Interfaces.Handlers;
using Application.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace Application.Handlers
{
    public class ProjectHandler : IProjectHandler
    {
        private readonly IProjectService _projectService;
        private readonly ILogger<ProjectHandler> _logger;

        public ProjectHandler(IProjectService projectService, ILogger<ProjectHandler> logger)
        {
            _projectService = projectService;
            _logger = logger;
        }

        public async Task<ProjectDTO> CreateNewProjectHandler(ProjectCreateCommand request)
        {
            try
            {
                var project = await _projectService.CreateNewProject(request);

                return project;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error CreateNewProjectHandler: " + ex);
                throw;
            }

        }

        public async Task DeleteProjectHandler(Guid id)
        {
            await _projectService.DeleteProjectAsync(id);
        }

        public async Task<List<ProjectDTO>> GetAllProjectsHandler()
        {
            return await _projectService.GetAllProjectsAsync();
        }

        public async Task<ProjectDTO> GetProjectHandler(Guid id)
        {
            return await _projectService.GetProjectByIdAsync(id);
        }

        public Task<ProjectDTO> UpdateProjectHandler(Guid id, ProjectUpdateCommand request)
        {
            return _projectService.UpdateProjectAsync(id, request);
        }
    }
}
