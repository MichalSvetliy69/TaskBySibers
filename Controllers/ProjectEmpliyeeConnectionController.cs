using Microsoft.AspNetCore.Mvc;

namespace TaskBySibers.Controllers
{
    public class ProjectEmpliyeeConnectionController : Controller
    {
        /// <summary>
        /// Ability to add and remove employees from a project
        /// (one employee can work on several projects simultaneously,
        /// and several people can work on one project)
        /// </summary>
        /// <returns></returns>
        /// 

        [HttpGet("GetEmployeesByProject")]
        public async Task<IActionResult> GetEmployeesByProject(int ProjectId)
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

        [HttpPost("AddEmployeeByProject")]
        public async Task<IActionResult> AddEmployeeByProject(int ProjectId)
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

        [HttpPost("DeleteEmployeeByProject")]
        public async Task<IActionResult> DeleteEmployeeByProject(int ProjectId)
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

        [HttpPost("ToIdentifyANewLeadByProject")]
        public async Task<IActionResult> ToIdentifyANewLeadByProject(int ProjectId)
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
