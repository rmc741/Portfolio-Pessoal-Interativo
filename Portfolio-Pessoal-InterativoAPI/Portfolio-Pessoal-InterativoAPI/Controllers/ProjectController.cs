using Application.DTOs;
using Application.Interfaces;
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

        [HttpGet("home")]
        public async Task<IActionResult> HomePage()
        {
            return Ok("Home Page com todos os projetos criados");
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewProject(ProjectDTO projectDTO)
        {
            var result = await _projectHandler.CreateNewProjectHandler(projectDTO);
            return Ok(result);
        }
    }
}
