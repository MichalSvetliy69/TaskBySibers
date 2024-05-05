using Microsoft.AspNetCore.Mvc;
using TaskBySibers.Services;
using TaskBySibers.Services.interfaces;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDProjectController : Controller
    {
        private readonly ICRUDProjectService _CRUDProjectService;
        public CRUDProjectController(ICRUDProjectService CRUDProjectService)
        {
            _CRUDProjectService = CRUDProjectService;
        }

        [HttpGet("GetProject")]
        public async Task<IActionResult> GetProject (int ProjectId)
        {
            try
            {
                return Ok(_CRUDProjectService.GetProject(ProjectId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetAllProjects")]
        public async Task<IActionResult> GetAllProjectsProject()
        {
            try
            {
                return Ok(_CRUDProjectService.GetAllProjects());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("AddProject")]
        public async Task<IActionResult> AddProject(ProjectVM projectVM)
        {
            try
            {
                _CRUDProjectService.AddProject(projectVM);
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("UpdateProject")]
        public async Task<IActionResult> UpdateProjects(ProjectVM projectVM)
        {
            try
            {
                _CRUDProjectService.UpdateProject(projectVM);
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("DeleteProject")]
        public async Task<IActionResult> DeleteProject(int ProjectId)
        {
            try
            {
                _CRUDProjectService.DeleteProject(ProjectId);
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
