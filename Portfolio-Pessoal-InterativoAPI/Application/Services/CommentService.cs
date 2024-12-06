using Application.CQRS.Commands;
using Application.DTOs;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Interface.Repository;
using Microsoft.Extensions.Logging;

namespace Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CommentService> _logger;

        public CommentService(ICommentRepository commentRepository, IMapper mapper, ILogger<CommentService> logger)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CommentDTO> CreateNewComment(CommentCreateCommand command)
        {
            var comment = _mapper.Map<Comment>(command);

            var newComment = await _commentRepository.AddAsync(comment);

            return _mapper.Map<CommentDTO>(newComment);
        }

        public async Task DeleteComment(Guid commentId)
        {
            var comment = await _commentRepository.GetByIdAsync(commentId);
            await _commentRepository.DeleteAsync(comment);
        }

        public async Task<List<CommentDTO>> GetAllCommentsByProjectId(Guid projectId)
        {
            try
            {
                _logger.LogInformation($"Buscando comentários para o projeto {projectId}.");

                var result = await _commentRepository.FindAsync(p => p.ProjectId == projectId);

                if (result == null || !result.Any())
                {
                    _logger.LogWarning($"Nenhum comentário encontrado para o projeto {projectId}.");
                    return new List<CommentDTO>();
                }

                _logger.LogInformation($"{result.Count} comentários encontrados para o projeto {projectId}.");
                return _mapper.Map<List<CommentDTO>>(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar comentários para o projeto {projectId}.");
                throw;
            }
        }

        public async Task<CommentDTO> GetCommentById(Guid commentId)
        {
            var comment = await _commentRepository.GetByIdAsync(commentId) 
                ?? throw new DirectoryNotFoundException("Comment not found");

            return _mapper.Map<CommentDTO>(comment);
        }

        public async Task<CommentDTO> UpdateComment(CommentUpdateCommand command)
        {
            var comment = await _commentRepository.GetByIdAsync(command.Id)
                ?? throw new DirectoryNotFoundException("Comment not found");

            _mapper.Map(command, comment);
            comment.UpdatedAt = command.UpdatedAt;

            var updateComment = await _commentRepository.UpdateAsync(comment);

            return _mapper.Map<CommentDTO>(updateComment);
        }
    }
}
