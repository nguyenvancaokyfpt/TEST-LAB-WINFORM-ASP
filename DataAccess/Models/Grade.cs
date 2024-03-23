using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Grade
{
    public int IdGrade { get; set; }

    public string GradeName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
