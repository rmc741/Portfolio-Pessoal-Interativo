using Domain.Entities;
using Domain.Interface.Repository;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Project> GetProjectsByIdWithCommentsAsync(Guid projectId)
        {
            return await _context.Projects
                .Include(e => e.CommentsList)
                .FirstOrDefaultAsync(e => e.Id == projectId);
        }

        // Adicione aqui métodos específicos para a entidade Project, se necessário
        //EXEMPLO:
        //public async Task<List<Project>> GetProjectsByCategoryAsync(string category)
        //{
        //    return await _dbSet.Where(p => p.Category == category).ToListAsync();
        //}

    }
}
