using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class GradeDTO
{
    public int IdGrade { get; set; }

    public string GradeName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }
}
