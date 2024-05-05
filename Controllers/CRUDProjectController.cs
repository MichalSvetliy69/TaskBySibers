using Microsoft.AspNetCore.Mvc;

namespace TaskBySibers.Controllers
{
    public class CRUDProjectController : Controller
    {
        [HttpGet("GetProject")]
        public async Task<IActionResult> GetProject (int ProjectId)
        {
            try
            {
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetAllProjects")]
        public async Task<IActionResult> GetAllProjectsProject(int ProjectId)
        {
            try
            {
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("AddProject")]
        public async Task<IActionResult> AddProject(int ProjectId)
        {
            try
            {
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("UpdateProject")]
        public async Task<IActionResult> UpdateProjects(int ProjectId)
        {
            try
            {
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
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
