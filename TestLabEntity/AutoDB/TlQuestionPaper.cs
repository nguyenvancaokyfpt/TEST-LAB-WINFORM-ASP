using System;
using System.Collections.Generic;

namespace TestLabEntity.AutoDB;

public partial class TlQuestionPaper
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public int PaperId { get; set; }

    public int Mark { get; set; }

    public virtual TlPaper Paper { get; set; } = null!;

    public virtual TlQuestion Question { get; set; } = null!;
}
