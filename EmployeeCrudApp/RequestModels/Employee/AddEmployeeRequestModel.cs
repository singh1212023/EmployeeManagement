using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudApp.RequestModels.Employee
{
    public class AddEmployeeRequestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string? Designation { get; set; }

        public DateOnly? DateOfJoining { get; set; }
    }
}
