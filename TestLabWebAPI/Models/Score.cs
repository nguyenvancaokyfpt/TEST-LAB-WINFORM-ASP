using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Models;

public partial class Score
{
    public int IdScore { get; set; }

    public int IdStudent { get; set; }

    public int TestCode { get; set; }

    public double ScoreNumber { get; set; }

    public string Detail { get; set; } = null!;

    public DateTime? TimeFinish { get; set; }

    public virtual Student IdStudentNavigation { get; set; } = null!;

    public virtual Test TestCodeNavigation { get; set; } = null!;
}
