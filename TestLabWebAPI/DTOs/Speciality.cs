using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class SpecialityDTO
{
    public int IdSpeciality { get; set; }

    public string SpecialityName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }
}
