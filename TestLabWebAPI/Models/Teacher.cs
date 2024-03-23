using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Models;

public partial class Teacher
{
    public int IdTeacher { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Avatar { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public string? Phone { get; set; }

    public int IdPermission { get; set; }

    public int IdSpeciality { get; set; }

    public DateTime? LastLogin { get; set; }

    public string? LastSeen { get; set; }

    public string? LastSeenUrl { get; set; }

    public DateTime? Timestamps { get; set; }

    public virtual Permission IdPermissionNavigation { get; set; } = null!;

    public virtual Speciality IdSpecialityNavigation { get; set; } = null!;
}
