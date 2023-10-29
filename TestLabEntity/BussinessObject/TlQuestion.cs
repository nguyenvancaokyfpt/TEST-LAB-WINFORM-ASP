using System;
using System.Collections.Generic;

namespace TestLabEntity.BusinessObject;

public partial class TlQuestionObj
{
    public int Id { get; set; }

    public string QuestionText { get; set; } = null!;

    public byte[]? QuestionImage { get; set; }
    public string QuestionImageBase64
    {
        get
        {
            if (QuestionImage != null)
            {
                return "data:image/png;base64," + Convert.ToBase64String(QuestionImage);
            }
            return "";
        }
    }
    public int CourseId { get; set; }

    public int ChapterId { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int? CreateBy { get; set; }

    public virtual TlChapterObj Chapter { get; set; } = null!;

    public virtual TlCourseObj Course { get; set; } = null!;

    public virtual TlAdminObj? CreateByNavigation { get; set; }

    public virtual ICollection<TlAnswerObj> TlAnswers { get; } = new List<TlAnswerObj>();

    public virtual ICollection<TlQuestionPaperObj> TlQuestionPapers { get; } = new List<TlQuestionPaperObj>();

    public virtual ICollection<TlSubmitpaperDetailObj> TlSubmitpaperDetails { get; } = new List<TlSubmitpaperDetailObj>();
    public bool IsSelected { get; set; } = false;
}
