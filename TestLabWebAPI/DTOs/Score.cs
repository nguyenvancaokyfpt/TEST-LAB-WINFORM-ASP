using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class ScoreDTO
{
    public int IdScore { get; set; }

    public int IdStudent { get; set; }

    public int TestCode { get; set; }

    public double ScoreNumber { get; set; }

    public string Detail { get; set; } = null!;

    public DateTime? TimeFinish { get; set; }
}
