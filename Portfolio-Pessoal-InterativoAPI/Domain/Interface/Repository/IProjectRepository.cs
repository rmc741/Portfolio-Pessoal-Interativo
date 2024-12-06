using Domain.Entities;

namespace Domain.Interface.Repository
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        // Adicione métodos específicos para Project, se necessário.
        // Exemplo:
        Task<Project> GetProjectsByIdWithCommentsAsync(Guid projectId);
    }
}
