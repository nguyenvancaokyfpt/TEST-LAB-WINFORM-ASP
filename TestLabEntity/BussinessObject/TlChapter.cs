using System;
using System.Collections.Generic;

namespace TestLabEntity.BusinessObject;

public partial class TlChapterObj
{
    public int Id { get; set; }

    public string ChapterName { get; set; } = null!;

    public int CourseId { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int CreateBy { get; set; }

    public virtual TlCourseObj Course { get; set; } = null!;

    public virtual TlAdminObj CreateByNavigation { get; set; } = null!;

    public virtual ICollection<TlQuestionObj> TlQuestions { get; } = new List<TlQuestionObj>();
    public bool IsSelected { get; set; } = false;
}
