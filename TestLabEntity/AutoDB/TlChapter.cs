using System;
using System.Collections.Generic;

namespace TestLabEntity.AutoDB;

public partial class TlChapter
{
    public int Id { get; set; }

    public string ChapterName { get; set; } = null!;

    public int CourseId { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int CreateBy { get; set; }

    public virtual TlCourse Course { get; set; } = null!;

    public virtual TlAdmin CreateByNavigation { get; set; } = null!;

    public virtual ICollection<TlQuestion> TlQuestions { get; } = new List<TlQuestion>();
}
