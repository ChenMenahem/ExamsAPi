using System;
using System.Collections.Generic;

namespace ExamDL.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdPermissions { get; set; }

    public virtual Permission IdPermissionsNavigation { get; set; } = null!;
}
