using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class StatusDTO
{
    public int IdStatus { get; set; }

    public string StatusName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }
}
