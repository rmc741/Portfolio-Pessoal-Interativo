using Application.CQRS.Commands;
using Application.DTOs;

namespace Application.Interfaces.Handlers
{
    public interface ICommentHandler
    {
        Task<CommentDTO> CreateNewCommentHandler(CommentCreateCommand commentRequest);
        Task<CommentDTO> UpdateCommentHandler(CommentUpdateCommand commentRequest);
        Task DeleteCommentHandler(Guid id);
        Task<CommentDTO> GetCommentHandler(Guid id);
        Task<List<CommentDTO>> GetAllCommentsByProjectIdHandler(Guid projectId);
    }
}
