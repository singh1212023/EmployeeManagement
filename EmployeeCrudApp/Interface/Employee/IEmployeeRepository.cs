using EmployeeCrudApp.RequestModels.Employee;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrudApp.Interface.Employee
{
    public interface IEmployeeRepository
    {
        Task<List<GetAllEmployeRequestModel>> GetAllEmployeesAsync();
        Task<GetAllEmployeRequestModel> GetEmployeeByIdAsync(int id);
        Task AddEmployeeAsync(AddEmployeeRequestModel employee);
        Task UpdateEmployeeAsync(AddEmployeeRequestModel employee);
        Task DeleteEmployeeAsync(int id);   
    }

    
}
