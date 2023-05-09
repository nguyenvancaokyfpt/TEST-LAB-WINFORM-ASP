using System;
using System.Collections.Generic;

namespace TestLabEntity.AutoDB;

public partial class TlAdmin
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual ICollection<TlAnswer> TlAnswers { get; } = new List<TlAnswer>();

    public virtual ICollection<TlChapter> TlChapters { get; } = new List<TlChapter>();

    public virtual ICollection<TlCourse> TlCourses { get; } = new List<TlCourse>();

    public virtual ICollection<TlPaper> TlPapers { get; } = new List<TlPaper>();

    public virtual ICollection<TlQuestion> TlQuestions { get; } = new List<TlQuestion>();
}
