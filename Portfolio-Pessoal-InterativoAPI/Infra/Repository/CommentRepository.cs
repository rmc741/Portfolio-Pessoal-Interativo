using Domain.Entities;
using Domain.Interface.Repository;
using Infra.Context;

namespace Infra.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
