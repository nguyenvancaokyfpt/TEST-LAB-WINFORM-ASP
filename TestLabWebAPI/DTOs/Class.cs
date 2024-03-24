using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class ClassDTO
{
    public string ClassName { get; set; } = null!;

    public int IdGrade { get; set; }

    public int IdSpeciality { get; set; }

    public DateTime? Timestamps { get; set; }
}
