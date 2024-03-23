using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Class
{
    public int IdClass { get; set; }

    public string ClassName { get; set; } = null!;

    public int IdGrade { get; set; }

    public int IdSpeciality { get; set; }

    public DateTime? Timestamps { get; set; }

    public virtual Grade IdGradeNavigation { get; set; } = null!;

    public virtual Speciality IdSpecialityNavigation { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
