using System;
using System.Collections.Generic;

namespace TestLabEntity.BusinessObject;

public partial class TlSubmitpaperObj
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int PaperId { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? StartTime { get; set; }

    public DateTime? UpdateAt { get; set; }

    public DateTime? DeteleAt { get; set; }

    public double? Mark { get; set; }

    public virtual TlPaperObj Paper { get; set; } = null!;

    public virtual TlStudentObj Student { get; set; } = null!;

    public virtual ICollection<TlSubmitpaperDetailObj> TlSubmitpaperDetails { get; } = new List<TlSubmitpaperDetailObj>();
    public bool IsSelected { get; set; } = false;
}
