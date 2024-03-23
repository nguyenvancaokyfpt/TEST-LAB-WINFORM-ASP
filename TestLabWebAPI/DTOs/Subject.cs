using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class SubjectDTO
{
    public int IdSubject { get; set; }

    public string SubjectName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }
}
