using System;
using System.Collections.Generic;

namespace TestLabEntity.AutoDB;

public partial class TlSubmitpaperDetail
{
    public int Id { get; set; }

    public int SubmitpaperId { get; set; }

    public int QuestionId { get; set; }

    public int AnswerId { get; set; }

    public virtual TlAnswer Answer { get; set; } = null!;

    public virtual TlQuestion Question { get; set; } = null!;

    public virtual TlSubmitpaper Submitpaper { get; set; } = null!;
}
