using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class PermissionDTO
{
    public string PermissionName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }
}
