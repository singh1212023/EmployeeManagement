namespace EmployeeCrudApp.RequestModels.Employee
{
    public class GetAllEmployeRequestModel
    {
        public int Id { get; set; }

            public string FirstName { get; set; } 
            public string LastName { get; set; } 

            public string Email { get; set; } 

            public string? Designation { get; set; }

            public DateOnly? DateOfJoining { get; set; }
    }
}
