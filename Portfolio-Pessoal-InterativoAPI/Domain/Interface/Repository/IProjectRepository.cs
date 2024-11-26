﻿using Domain.Entities;

namespace Domain.Interface.Repository
{
    public interface IProjectRepository
    {
        Task<Project> CreateNewProjectAsync(Project project);
        Task<List<Project>> GetProjectsAsync();
        Task<Project> GetProjectByIdAsync(Guid id);
        Task<Project> UpdateProjectAsync(Guid id, Project project);
        Task DeleteProjectAsync(Guid id);
    }
}