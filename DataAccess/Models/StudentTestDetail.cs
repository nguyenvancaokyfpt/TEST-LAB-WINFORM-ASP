﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class StudentTestDetail
{
    public int Id { get; set; }

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
