using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Status
{
    public int IdStatus { get; set; }

    public string StatusName { get; set; } = null!;

    public DateTime? Timestamps { get; set; }

    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}
