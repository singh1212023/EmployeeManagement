using EmployeeCrudApp.Interface.Employee;
using EmployeeCrudApp.Models;
using EmployeeCrudApp.RequestModels.Employee;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrudApp.Services.Employee
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly PracticedbContext context;

        public EmployeeService(PracticedbContext _context)
        {
            context = _context;
        }
        public async Task<List<GetAllEmployeRequestModel>> GetAllEmployeesAsync()
        {
            return await context.Employees
       .Select(employee => new GetAllEmployeRequestModel
       {
           Id = employee.Id,
           FirstName = employee.FirstName,
           LastName = employee.LastName,
           Email = employee.Email,
           Designation = employee.Designation,
           DateOfJoining = employee.DateOfJoining
       })
       .ToListAsync();
        }

        public async Task<GetAllEmployeRequestModel> GetEmployeeByIdAsync(int id)
        {
            return await context.Employees.Where(employee => employee.Id == id).Select(employee => new GetAllEmployeRequestModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Designation = employee.Designation,
                DateOfJoining = employee.DateOfJoining
            }).FirstOrDefaultAsync();

        }

        public async Task AddEmployeeAsync(AddEmployeeRequestModel model)
        {
            var employee = new Models.Employee
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Designation = model.Designation,
                DateOfJoining = model.DateOfJoining
            };

            context.Employees.Add(employee);
            await context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeAsync( AddEmployeeRequestModel updatedEmployee)
        {

            var employee = await context.Employees
                                        .Where(e => e.Id == updatedEmployee.Id)
                                        .FirstOrDefaultAsync();
            if (employee != null)
            {
                employee.FirstName = updatedEmployee.FirstName;
                employee.LastName = updatedEmployee.LastName;
                employee.Email = updatedEmployee.Email;
                employee.Designation = updatedEmployee.Designation;
                employee.DateOfJoining = updatedEmployee.DateOfJoining;

                context.Employees.Update(employee);
                await context.SaveChangesAsync();
            }
            else
            {

                throw new Exception("Employee not found");
            }
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = await context.Employees.FindAsync(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                await context.SaveChangesAsync();
            }
        }
    }
}