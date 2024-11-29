using Application.CQRS.Commands;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Handlers
{
    public interface IProjectHandler
    {
        Task<ProjectDTO> CreateNewProjectHandler(ProjectCreateCommand projectDTO);
        Task<ProjectDTO> UpdateProjectHandler(ProjectUpdateCommand projectDTO);
        Task DeleteProjectHandler(Guid id);
        Task<ProjectDTO> GetProjectHandler(Guid id);
        Task<List<ProjectDTO>> GetAllProjectsHandler();
    }
}
