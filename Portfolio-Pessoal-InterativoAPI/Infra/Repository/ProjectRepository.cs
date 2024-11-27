using Domain.Entities;
using Domain.Interface.Repository;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Project> CreateNewProjectAsync(Project project)
        {
            await _context.AddAsync(project);
            await _context.SaveChangesAsync();
            var savedProject = await _context.Projects.Where(d => project.Id == d.Id).FirstOrDefaultAsync();
            return savedProject;
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
