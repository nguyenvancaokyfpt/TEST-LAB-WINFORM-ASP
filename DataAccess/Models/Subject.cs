using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Subject
{
    public int IdSubject { get; set; }

    public string SubjectName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}
