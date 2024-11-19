using System;
using System.Collections.Generic;

namespace EmployeeCrudApp.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Designation { get; set; }

    public DateOnly? DateOfJoining { get; set; }
}
