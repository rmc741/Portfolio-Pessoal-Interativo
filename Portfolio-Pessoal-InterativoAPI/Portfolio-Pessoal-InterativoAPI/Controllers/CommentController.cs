using Application.CQRS.Commands;
using Application.Interfaces.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Pessoal_InterativoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentHandler _commentHandler;

        public CommentController(ICommentHandler commentHandler)
        {
            _commentHandler = commentHandler;
        }

        [HttpPost("{projectId}")]
        public async Task<IActionResult> CreateNewComment(Guid projectId, CommentCreateCommand commentCommand)
        {
            var result = await _commentHandler.CreateNewCommentHandler(commentCommand);
            return Ok(result);
        }

        [HttpGet("{projectId}")]
        public async Task<IActionResult> GetCommentsByProjectId(Guid projectId)
        {
            var result = await _commentHandler.GetAllCommentsByProjectIdHandler(projectId);
            return Ok(result);
        }

        [HttpPut("{commnetId}")]
        public async Task<IActionResult> UpdateCommentById([FromBody]CommentUpdateCommand commentCommand)
        {
            var result = await _commentHandler.UpdateCommentHandler(commentCommand);
            return Ok(result);
        }

        [HttpDelete("{commnetId}")]
        public async Task<IActionResult> RemoveCommentById(Guid commnetId)
        {
            await _commentHandler.DeleteCommentHandler(commnetId);
            return NoContent();
        }
    }
}
