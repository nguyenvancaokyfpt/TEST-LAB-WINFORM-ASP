using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Test
{
    public string TestName { get; set; } = null!;

    public int TestCode { get; set; }

    public string Password { get; set; } = null!;

    public int IdSubject { get; set; }

    public int TotalQuestions { get; set; }

    public int TimeToDo { get; set; }

    public string? Note { get; set; }

    public int IdStatus { get; set; }

    public DateTime? Timestamps { get; set; }

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual Subject IdSubjectNavigation { get; set; } = null!;

    public virtual ICollection<QuestsOfTest> QuestsOfTests { get; set; } = new List<QuestsOfTest>();

    public virtual ICollection<Score> Scores { get; set; } = new List<Score>();
}
