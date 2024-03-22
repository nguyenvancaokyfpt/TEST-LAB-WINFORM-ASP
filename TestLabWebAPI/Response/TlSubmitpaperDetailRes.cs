using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Response;

public partial class TlSubmitpaperDetailRes
{
    public int Id { get; set; }

    public int SubmitpaperId { get; set; }

    public int QuestionId { get; set; }

    public int AnswerId { get; set; }

    public virtual TlAnswerRes Answer { get; set; } = null!;

    public virtual TlQuestionRes Question { get; set; } = null!;

    public virtual TlSubmitpaperRes Submitpaper { get; set; } = null!;
}
