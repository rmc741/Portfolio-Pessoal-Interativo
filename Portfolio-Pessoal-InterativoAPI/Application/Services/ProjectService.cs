using Application.CQRS.Commands;
using Application.DTOs;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Interface.Repository;
using Microsoft.Extensions.Logging;

namespace Application.Services;
public class ProjectService : IProjectService
{
    private readonly IMapper _mapper;
    private readonly ILogger<ProjectService> _logger;
    private readonly IProjectRepository _projectRepository;

    public ProjectService(
        IMapper mapper,
        ILogger<ProjectService> logger,
        IProjectRepository projectRepository)
    {
        _mapper = mapper;
        _logger = logger;
        _projectRepository = projectRepository;
    }

    public async Task<ProjectDTO> CreateNewProject(ProjectCreateCommand request)
    {
        var project = _mapper.Map<Project>(request);

        var newProject = await _projectRepository.AddAsync(project);

        return _mapper.Map<ProjectDTO>(newProject);
    }

    public async Task<List<ProjectDTO>> GetAllProjectsAsync()
    {
        var projectList = await _projectRepository.GetAllAsync();

        return _mapper.Map<List<ProjectDTO>>(projectList);
    }

    public async Task<ProjectDTO> GetProjectByIdAsync(Guid id)
    {
        var project = await _projectRepository.GetByIdAsync(id)
            ?? throw new DirectoryNotFoundException("Project not found");

        return _mapper.Map<ProjectDTO>(project);
    }

    public async Task<ProjectDTO> GetProjectByIdWithComments(Guid id)
    {
        var project = await _projectRepository.GetProjectsByIdWithCommentsAsync(id)
            ?? throw new DirectoryNotFoundException("Project not found");

        return _mapper.Map<ProjectDTO>(project);
    }

    public async Task<ProjectDTO> UpdateProjectAsync(ProjectUpdateCommand request)
    {
        var project = await _projectRepository.GetByIdAsync(request.Id)
            ?? throw new DirectoryNotFoundException("Project not found");

        _mapper.Map(request, project);
        project.UpdatedAt = request.UpdatedAt;

        var updatedProject = await _projectRepository.UpdateAsync(project);

        return _mapper.Map<ProjectDTO>(updatedProject);
    }

    public async Task DeleteProjectById(Guid id)
    {
        var project = await _projectRepository.GetByIdAsync(id)
            ?? throw new DirectoryNotFoundException("Project not found");

        await _projectRepository.DeleteAsync(project);
    }
}
