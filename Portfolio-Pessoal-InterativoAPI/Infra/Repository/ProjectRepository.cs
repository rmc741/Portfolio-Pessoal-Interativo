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

        public async Task<Project> GetProjectByIdAsync(Guid id)
        {
            return await _context.Projects.SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<Project>> GetProjectsAsync()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> UpdateProjectAsync(Project project)
        {
            var updatedProject = _context.Projects.Update(project);
            await _context.SaveChangesAsync();

            return await _context.Projects.SingleOrDefaultAsync(e => e.Id == project.Id);
        }
    }
}
