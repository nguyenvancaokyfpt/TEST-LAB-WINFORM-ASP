using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Response;

public partial class TlQuestionRes
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

    public virtual TlChapterRes Chapter { get; set; } = null!;

    public virtual TlCourseRes Course { get; set; } = null!;

    public virtual TlAdminRes? CreateByNavigation { get; set; }

    public virtual ICollection<TlAnswerRes> TlAnswers { get; } = new List<TlAnswerRes>();

    public virtual ICollection<TlQuestionPaperRes> TlQuestionPapers { get; } = new List<TlQuestionPaperRes>();

    public virtual ICollection<TlSubmitpaperDetailRes> TlSubmitpaperDetails { get; } = new List<TlSubmitpaperDetailRes>();
}
