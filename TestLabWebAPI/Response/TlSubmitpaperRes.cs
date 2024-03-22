using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Response;

public partial class TlSubmitpaperRes
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int PaperId { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? StartTime { get; set; }

    public DateTime? UpdateAt { get; set; }

    public DateTime? DeteleAt { get; set; }

    public double? Mark { get; set; }

    public virtual TlPaperRes Paper { get; set; } = null!;

    public virtual TlStudentRes Student { get; set; } = null!;

    public virtual ICollection<TlSubmitpaperDetailRes> TlSubmitpaperDetails { get; } = new List<TlSubmitpaperDetailRes>();
}
