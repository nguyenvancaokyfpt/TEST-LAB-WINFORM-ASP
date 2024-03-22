using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Response;

public partial class TlAdminRes
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public virtual ICollection<TlAnswerRes> TlAnswers { get; } = new List<TlAnswerRes>();

    public virtual ICollection<TlChapterRes> TlChapters { get; } = new List<TlChapterRes>();

    public virtual ICollection<TlCourseRes> TlCourses { get; } = new List<TlCourseRes>();

    public virtual ICollection<TlPaperRes> TlPapers { get; } = new List<TlPaperRes>();

    public virtual ICollection<TlQuestionRes> TlQuestions { get; } = new List<TlQuestionRes>();
}
