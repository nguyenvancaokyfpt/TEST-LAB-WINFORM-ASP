using System;
using System.Collections.Generic;

namespace TestLabWebAPI.DTOs;

public partial class StudentTestDetailDTO
{
    public int IdStudent { get; set; }

    public int TestCode { get; set; }

    public int IdQuestion { get; set; }

    public string AnswerA { get; set; } = null!;

    public string AnswerB { get; set; } = null!;

    public string AnswerC { get; set; } = null!;

    public string AnswerD { get; set; } = null!;

    public string? StudentAnswer { get; set; }

    public DateTime? Timestamps { get; set; }
}
