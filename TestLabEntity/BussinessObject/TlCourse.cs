using System;
using System.Collections.Generic;

namespace TestLabEntity.BusinessObject;

public partial class TlCourseObj
{
    public int Id { get; set; }

    public string CourseName { get; set; } = null!;

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int CreateBy { get; set; }

    public virtual TlAdminObj CreateByNavigation { get; set; } = null!;

    public virtual ICollection<TlChapterObj> TlChapters { get; } = new List<TlChapterObj>();

    public virtual ICollection<TlPaperObj> TlPapers { get; } = new List<TlPaperObj>();

    public virtual ICollection<TlQuestionObj> TlQuestions { get; } = new List<TlQuestionObj>();
    public bool IsSelected { get; set; } = false;
}
