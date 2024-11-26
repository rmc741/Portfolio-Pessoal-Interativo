using Domain.Entities;
using Domain.Interface.Repository;

namespace Infra.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        public Task<Project> CreateNewProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProjectAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetProjectByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Project>> GetProjectsAsync()
        {
            throw new NotImplementedException("Entrou no repository");
        }

        public Task<Project> UpdateProjectAsync(Guid id, Project project)
        {
            throw new NotImplementedException();
        }
    }
}
