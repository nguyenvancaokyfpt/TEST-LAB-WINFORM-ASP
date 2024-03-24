using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class QuestsOfTestDTO
{
    public int TestCode { get; set; }

    public int IdQuestion { get; set; }

    public DateTime? Timestamps { get; set; }
}
