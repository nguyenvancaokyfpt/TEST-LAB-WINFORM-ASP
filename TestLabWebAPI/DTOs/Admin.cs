using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class AdminDTO
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Avatar { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Birthday { get; set; }

    public string? Phone { get; set; }

    public int IdPermission { get; set; }
}
