using System;
using System.Collections.Generic;

namespace TestLabEntity.AutoDB;

public partial class TlAnswer
{
    public int Id { get; set; }

    public string AnswerText { get; set; } = null!;

    public int QuestionId { get; set; }

    public bool IsCorrect { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int CreateBy { get; set; }

    public virtual TlAdmin CreateByNavigation { get; set; } = null!;

    public virtual TlQuestion Question { get; set; } = null!;

    public virtual ICollection<TlSubmitpaperDetail> TlSubmitpaperDetails { get; } = new List<TlSubmitpaperDetail>();
}
