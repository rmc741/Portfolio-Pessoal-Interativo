using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProjectHandler
    {
        Task<ProjectDTO> CreateNewProjectHandler(ProjectDTO projectDTO);
        Task<ProjectDTO> UpdateProjectHandler(Guid id, ProjectDTO projectDTO);
        Task DeleteProjectHandler(Guid id);
        Task<ProjectDTO> GetProjectHandler(Guid id);
        Task<List<ProjectDTO>> GetAllProjectsHandler();
    }
}
