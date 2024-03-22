using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Response;

public partial class TlQuestionPaperRes
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public int PaperId { get; set; }

    public int Mark { get; set; }

    public virtual TlPaperRes Paper { get; set; } = null!;

    public virtual TlQuestionRes Question { get; set; } = null!;
}
