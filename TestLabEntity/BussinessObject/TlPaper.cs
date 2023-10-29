using System;
using System.Collections.Generic;

namespace TestLabEntity.BusinessObject;

public partial class TlPaperObj
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

    public virtual TlCourseObj? Course { get; set; }

    public virtual TlAdminObj CreateByNavigation { get; set; } = null!;

    public virtual ICollection<TlQuestionPaperObj> TlQuestionPapers { get; } = new List<TlQuestionPaperObj>();

    public virtual ICollection<TlSubmitpaperObj> TlSubmitpapers { get; } = new List<TlSubmitpaperObj>();
    public bool IsSelected { get; set; } = false;
}
