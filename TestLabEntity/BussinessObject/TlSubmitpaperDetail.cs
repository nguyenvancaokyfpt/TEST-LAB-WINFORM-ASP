using System;
using System.Collections.Generic;

namespace TestLabEntity.BusinessObject;

public partial class TlSubmitpaperDetailObj
{
    public int Id { get; set; }

    public int SubmitpaperId { get; set; }

    public int QuestionId { get; set; }

    public int AnswerId { get; set; }

    public virtual TlAnswerObj Answer { get; set; } = null!;

    public virtual TlQuestionObj Question { get; set; } = null!;

    public virtual TlSubmitpaperObj Submitpaper { get; set; } = null!;
    public bool IsSelected { get; set; } = false;
}
