using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class SpecialityDTO
{
    public string SpecialityName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }
}
