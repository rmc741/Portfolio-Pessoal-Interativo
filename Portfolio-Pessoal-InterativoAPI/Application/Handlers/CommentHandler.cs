using Application.CQRS.Commands;
using Application.DTOs;
using Application.Interfaces.Handlers;
using Application.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace Application.Handlers
{
    public class CommentHandler : ICommentHandler
    {
        private readonly ICommentService _commentService;
        private readonly ILogger<CommentHandler> _logger;

        public CommentHandler(ICommentService commentService, ILogger<CommentHandler> logger)
        {
            _commentService = commentService;
            _logger = logger;
        }

        public async Task<CommentDTO> CreateNewCommentHandler(CommentCreateCommand commentRequest)
        {
            return await _commentService.CreateNewComment(commentRequest);
        }

        public async Task DeleteCommentHandler(Guid id)
        {
            await _commentService.DeleteComment(id);
        }

        //talvez não precise dessa função
        public async Task<List<CommentDTO>> GetAllCommentsByProjectIdHandler(Guid projectId)
        {
            return await _commentService.GetAllCommentsByProjectId(projectId);
        }

        public async Task<CommentDTO> GetCommentHandler(Guid id)
        {
            return await _commentService.GetCommentById(id);
        }

        public Task<CommentDTO> UpdateCommentHandler(CommentUpdateCommand commentRequest)
        {
            return _commentService.UpdateComment(commentRequest);
        }
    }
}
