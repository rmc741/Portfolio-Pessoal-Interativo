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
            return Ok();
        }

        [HttpGet("{projectId}")]
        public async Task<IActionResult> GetCommentsByProjectId(Guid projectId)
        {
            return Ok();
        }

        [HttpPut("{commnetId}")]
        public async Task<IActionResult> UpdateCommentById([FromBody]CommentUpdateCommand commentCommand)
        {
            return Ok();
        }

        [HttpDelete("{commnetId}")]
        public async Task<IActionResult> RemoveCommentById(Guid commnetId)
        {
            return NoContent();
        }
    }
}
