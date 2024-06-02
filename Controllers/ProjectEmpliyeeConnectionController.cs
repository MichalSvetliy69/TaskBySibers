using Microsoft.AspNetCore.Mvc;
using TaskBySibers.Services.Implementation;
using TaskBySibers.Services.interfaces;
using TaskBySibers.ViewModels;

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
        private readonly IProjectEmpliyeeConnectionService _projectEmpliyeeConnectionService;
        public ProjectEmpliyeeConnectionController(IProjectEmpliyeeConnectionService projectEmpliyeeConnectionService)
        {
            _projectEmpliyeeConnectionService = projectEmpliyeeConnectionService;
        }

        [HttpGet("GetEmployeesByProject")]
        public async Task<IActionResult> GetEmployeesByProject(int ProjectId)
        {
            try
            {
                return Ok(_projectEmpliyeeConnectionService.GetAllEmployeesByProject(ProjectId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("AddEmployeeByProject")]
        public async Task<IActionResult> AddEmployeeByProject(ProjectEmployeeVM projectEmployeeVM)
        {
            try
            {
                return Ok(_projectEmpliyeeConnectionService.AddEmployeeByProject(projectEmployeeVM));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("DeleteEmployeeByProject")]
        public async Task<IActionResult> DeleteEmployeeByProject(ProjectEmployeeVM projectEmployeeVM)
        {
            try
            {
                return Ok(_projectEmpliyeeConnectionService.DeleteEmployeeByProject(projectEmployeeVM));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }
}
