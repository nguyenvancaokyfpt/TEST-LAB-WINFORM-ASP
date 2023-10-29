using System;
using System.Collections.Generic;

namespace TestLabEntity.BusinessObject;

public partial class TlAnswerObj
{
    public int Id { get; set; }

    public string AnswerText { get; set; } = null!;

    public int QuestionId { get; set; }

    public bool IsCorrect { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int CreateBy { get; set; }

    public virtual TlAdminObj CreateByNavigation { get; set; } = null!;

    public virtual TlQuestionObj Question { get; set; } = null!;

    public virtual ICollection<TlSubmitpaperDetailObj> TlSubmitpaperDetails { get; } = new List<TlSubmitpaperDetailObj>();
    public bool IsSelected { get; set; } = false;
}
