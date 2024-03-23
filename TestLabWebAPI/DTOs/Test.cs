using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class TestDTO
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

    public virtual StatusDTO IdStatusNavigation { get; set; } = null!;

    public virtual SubjectDTO IdSubjectNavigation { get; set; } = null!;

    public virtual ICollection<QuestsOfTestDTO> QuestsOfTests { get; set; } = new List<QuestsOfTestDTO>();

    public virtual ICollection<ScoreDTO> Scores { get; set; } = new List<ScoreDTO>();
}
