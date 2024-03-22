using TestLabEntity.AutoDB;

namespace TestLabWebAPI.Response;

public class TlChapterRes
{
    public int Id { get; set; }

    public string ChapterName { get; set; } = null!;

    public int CourseId { get; set; }

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int CreateBy { get; set; }

    public virtual TlCourseRes Course { get; set; } = null!;

    public virtual TlAdminRes CreateByNavigation { get; set; } = null!;

    public virtual ICollection<TlQuestionRes> TlQuestions { get; } = new List<TlQuestionRes>();
}
