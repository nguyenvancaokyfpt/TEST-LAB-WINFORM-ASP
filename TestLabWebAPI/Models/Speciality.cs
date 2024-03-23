using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Models;

public partial class Speciality
{
    public int IdSpeciality { get; set; }

    public string SpecialityName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
