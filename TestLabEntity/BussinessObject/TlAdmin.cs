using System;
using System.Collections.Generic;

namespace TestLabEntity.BusinessObject;

public partial class TlAdminObj
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual ICollection<TlAnswerObj> TlAnswers { get; } = new List<TlAnswerObj>();

    public virtual ICollection<TlChapterObj> TlChapters { get; } = new List<TlChapterObj>();

    public virtual ICollection<TlCourseObj> TlCourses { get; } = new List<TlCourseObj>();

    public virtual ICollection<TlPaperObj> TlPapers { get; } = new List<TlPaperObj>();

    public virtual ICollection<TlQuestionObj> TlQuestions { get; } = new List<TlQuestionObj>();
}
