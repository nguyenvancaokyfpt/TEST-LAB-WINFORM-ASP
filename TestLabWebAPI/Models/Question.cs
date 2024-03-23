using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Models;

public partial class Question
{
    public int IdQuestion { get; set; }

    public int IdSubject { get; set; }

    public int Unit { get; set; }

    public string? ImgContent { get; set; }

    public string Content { get; set; } = null!;

    public string AnswerA { get; set; } = null!;

    public string AnswerB { get; set; } = null!;

    public string AnswerC { get; set; } = null!;

    public string AnswerD { get; set; } = null!;

    public string CorrectAnswer { get; set; } = null!;

    public DateTime? Timestamps { get; set; }

    public virtual Subject IdSubjectNavigation { get; set; } = null!;

    public virtual ICollection<QuestsOfTest> QuestsOfTests { get; set; } = new List<QuestsOfTest>();
}
