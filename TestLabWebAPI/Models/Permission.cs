using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Models;

public partial class Permission
{
    public int IdPermission { get; set; }

    public string PermissionName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
