using Microsoft.AspNetCore.Mvc;

namespace TaskBySibers.Controllers
{
    public class CRUDEmployeeController : Controller
    {
        [HttpGet("GetEmployee")]
        public async Task<IActionResult> GetEmployee(int ProjectId)
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

        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees(int ProjectId)
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

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(int ProjectId)
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

        [HttpPost("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(int ProjectId)
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

        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(int ProjectId)
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
