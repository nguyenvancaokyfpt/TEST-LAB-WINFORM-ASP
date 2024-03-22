using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Response;

public partial class TlCourseRes
{
    public int Id { get; set; }

    public string CourseName { get; set; } = null!;

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int CreateBy { get; set; }

    public virtual TlAdminRes CreateByNavigation { get; set; } = null!;

    public virtual ICollection<TlChapterRes> TlChapters { get; } = new List<TlChapterRes>();

    public virtual ICollection<TlPaperRes> TlPapers { get; } = new List<TlPaperRes>();

    public virtual ICollection<TlQuestionRes> TlQuestions { get; } = new List<TlQuestionRes>();
}
