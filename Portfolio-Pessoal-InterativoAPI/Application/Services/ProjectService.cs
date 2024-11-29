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
            var projectListDTO = new List<ProjectDTO>();
            var projectList = await _projectRepository.GetProjectsAsync();
            foreach (var project in projectList)
            {
                projectListDTO.Add(_mapper.Map<ProjectDTO>(project));
            }

            return projectListDTO;
        }

        public async Task<ProjectDTO> GetProjectByIdAsync(Guid id)
        {
            var project = await _projectRepository.GetProjectByIdAsync(id);
            var projectDTO = _mapper.Map<ProjectDTO>(project);
            return projectDTO;
        }

        public async Task<ProjectDTO> UpdateProjectAsync(ProjectUpdateCommand request)
        {
            var project = await _projectRepository.GetProjectByIdAsync(request.Id);

            //pensar em uma forma melhor de realizar esse update
            project.Name = request.Name;
            project.Description = request.Description;
            project.UrlGit = request.UrlGit;
            project.Tags = request.Tags;
            project.UpdatedAt = request.UpdatedAt;

            var projectDTO = _mapper.Map<ProjectDTO>(await _projectRepository.UpdateProjectAsync(project));
            return projectDTO;
        }

        public Task DeleteProjectAsync(Guid id)
        {
            throw new NotImplementedException("Função para remover projeto ainda n implementado");
        }
    }
}
