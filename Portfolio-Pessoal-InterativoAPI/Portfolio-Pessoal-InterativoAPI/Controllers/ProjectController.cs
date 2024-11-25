using Application.DTOs;
using Application.Interfaces.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Pessoal_InterativoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectHandler _projectHandler;

        public ProjectController(IProjectHandler projectHandler)
        {
            _projectHandler = projectHandler;
        }

        [HttpGet]
        public async Task<IActionResult> HomePage()
        {
            var result = await _projectHandler.GetAllProjectsHandler();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectById(Guid id)
        {
            var result = await _projectHandler.GetProjectHandler(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewProject([FromBody] ProjectDTO projectDTO)
        {
            var result = await _projectHandler.CreateNewProjectHandler(projectDTO);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(Guid id, [FromBody] ProjectDTO projectDTO)
        {
            var result = await _projectHandler.UpdateProjectHandler(id,projectDTO);
            return Ok(result);
        }
    }
}
