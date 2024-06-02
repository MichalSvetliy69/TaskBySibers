using Microsoft.AspNetCore.Mvc;
using TaskBySibers.Models;
using TaskBySibers.Services;
using TaskBySibers.Services.interfaces;
using TaskBySibers.ViewModels;
using TaskBySibers.ViewModels.ProjectVM;

namespace TaskBySibers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDEmployeeController : Controller
    {

        private readonly ICRUDEmployeeService _CRUDEmployeeService;
        public CRUDEmployeeController(ICRUDEmployeeService CRUDEmployeeService)
        {
            _CRUDEmployeeService = CRUDEmployeeService;
        }

        [HttpGet("GetEmployee")]
        public async Task<IActionResult> GetEmployee(int ProjectId)
        {
            try
            {
                return Ok(_CRUDEmployeeService.GetEmployee(ProjectId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees() //получение всех сотрудников
        {
            try
            {
                return Ok(_CRUDEmployeeService.GetAllEmployees());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetAllEmployeesByProject")]
        public async Task<IActionResult> GetAllEmployeesByProject(int projectId) //получение всех сотрудников
        {
            try
            {
                return Ok(_CRUDEmployeeService.GetAllEmployeesByProject(projectId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(EmployeeVM employeeVM)
        {
            try
            {
                _CRUDEmployeeService.AddEmployee(employeeVM);
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(EmployeeVM employeeVM)
        {
            try
            {
                _CRUDEmployeeService.UpdateEmployee(employeeVM);
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(int employeeId)
        {
            try
            {
                _CRUDEmployeeService.DeleteEmployee(employeeId);
                return Ok($"Succssful complete!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
