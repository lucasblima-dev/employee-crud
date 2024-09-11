using Microsoft.AspNetCore.Mvc;
using CrudApi.Service.EmployeesService;
using CrudApi.Models;

namespace CrudApi.Controllers
{
    //[Route("[controller]")]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeInterface _employeeInterface;
        public EmployeeController(IEmployeeInterface employeeInterface)
        {
            _employeeInterface = employeeInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<EmployeeModel>>>> GetEmployees()
        {
            return Ok(await _employeeInterface.GetEmployees());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> GetEmployeesById(int id)
        {
            ServiceResponse<EmployeeModel> serviceResponse = await _employeeInterface.GetEmployeesById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<EmployeeModel>>>> CreateEmployees(EmployeeModel newEmployee)
        {
            return Ok(await _employeeInterface.CreateEmployee(newEmployee));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<EmployeeModel>>>> UpdateEmployee(EmployeeModel editedEmployee)
        {
            ServiceResponse<List<EmployeeModel>> serviceResponse = await _employeeInterface.UpdateEmployee(editedEmployee);

            return Ok(serviceResponse);
        }

        [HttpPut("inactiveEmployee")]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> InactiveEmployee(int id)
        {
            ServiceResponse<List<EmployeeModel>> serviceResponse = await _employeeInterface.InactiveEmployee(id);

            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<EmployeeModel>>>> DeleteEmployee(int id)
        {
            ServiceResponse<List<EmployeeModel>> serviceResponse = await _employeeInterface.DeleteEmployee(id);

            return Ok(serviceResponse);
        }
    }
}