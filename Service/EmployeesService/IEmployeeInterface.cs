
using CrudApi.Models;

namespace CrudApi.Service.EmployeesService
{
    public interface IEmployeeInterface
    {
        Task<ServiceResponse<List<EmployeeModel>>> GetEmployees();

        Task<ServiceResponse<EmployeeModel>> GetEmployeesById(int id);

        Task<ServiceResponse<List<EmployeeModel>>> CreateEmployee(EmployeeModel newEmployee);

        Task<ServiceResponse<List<EmployeeModel>>> UpdateEmployee(EmployeeModel editedEmployee);

        Task<ServiceResponse<List<EmployeeModel>>> DeleteEmployee(int id);

        Task<ServiceResponse<List<EmployeeModel>>> InactiveEmployee(int id);
    }
}