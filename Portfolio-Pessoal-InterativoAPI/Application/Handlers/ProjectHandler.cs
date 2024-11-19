using Application.DTOs;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class ProjectHandler : IProjectHandler
    {
        public Task<ProjectDTO> CreateNewProjectHandler(ProjectDTO projectDTO)
        {
            throw new NotImplementedException("Criação de projeto ainda não implementada!!");
        }

        public Task DeleteProjectHandler(Guid id)
        {
            throw new NotImplementedException("Função ainda não implementada!");
        }

        public Task<ProjectDTO> UpdateProjectHandler(ProjectDTO projectDTO)
        {
            throw new NotImplementedException("Função ainda não implementada!");
        }
    }
}
