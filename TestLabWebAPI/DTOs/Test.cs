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
}
