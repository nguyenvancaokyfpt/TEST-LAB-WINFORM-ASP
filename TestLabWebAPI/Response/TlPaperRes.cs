using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Response;

public partial class TlPaperRes
{
    public int Id { get; set; }

    public string PaperName { get; set; } = null!;

    public string PaperCode { get; set; } = null!;

    public int QuestionNum { get; set; }

    public int Duration { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool IsOpen { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int CreateBy { get; set; }

    public int? CourseId { get; set; }

    public virtual TlCourseRes? Course { get; set; }

    public virtual TlAdminRes CreateByNavigation { get; set; } = null!;

    public virtual ICollection<TlQuestionPaperRes> TlQuestionPapers { get; } = new List<TlQuestionPaperRes>();

    public virtual ICollection<TlSubmitpaperRes> TlSubmitpapers { get; } = new List<TlSubmitpaperRes>();
}
