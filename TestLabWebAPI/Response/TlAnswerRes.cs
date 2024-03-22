using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Response;

public partial class TlAnswerRes
{
    public int Id { get; set; }

    public string AnswerText { get; set; } = null!;

    public int QuestionId { get; set; }

    public bool IsCorrect { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int CreateBy { get; set; }

    public virtual TlAdminRes CreateByNavigation { get; set; } = null!;

    public virtual TlQuestionRes Question { get; set; } = null!;

    public virtual ICollection<TlSubmitpaperDetailRes> TlSubmitpaperDetails { get; } = new List<TlSubmitpaperDetailRes>();
}
