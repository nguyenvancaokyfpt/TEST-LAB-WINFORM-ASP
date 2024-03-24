using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Responses;

public partial class QuestionRes
{
    public int IdQuestion { get; set; }

    public int Unit { get; set; }

    public string? ImgContent { get; set; }

    public string? ImgBase64 { get; set; }

    public string Content { get; set; } = null!;

    public string AnswerA { get; set; } = null!;

    public string AnswerB { get; set; } = null!;

    public string AnswerC { get; set; } = null!;

    public string AnswerD { get; set; } = null!;

    public string CorrectAnswer { get; set; } = null!;

    public string SubjectName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }
}
