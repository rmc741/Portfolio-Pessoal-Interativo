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
        Task<ProjectDTO> UpdateProjectHandler(ProjectDTO projectDTO);
        Task DeleteProjectHandler(Guid id);
    }
}
