using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class PermissionDTO
{
    public int IdPermission { get; set; }

    public string PermissionName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }
}
