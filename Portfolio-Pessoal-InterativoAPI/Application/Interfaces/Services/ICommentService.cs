using Application.CQRS.Commands;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface ICommentService
    {
        Task<List<CommentDTO>> GetAllCommentsByProjectId(Guid projectId);
        Task<CommentDTO> GetCommentById(Guid commentId);
        Task<CommentDTO> CreateNewComment(CommentCreateCommand command);
        Task<CommentDTO> UpdateComment(CommentUpdateCommand command);
        Task DeleteComment(Guid commentId);
    }
}
