using System;
using System.Collections.Generic;

namespace TestLabEntity.AutoDB;

public partial class TlSubmitpaper
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int PaperId { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public DateTime? StartTime { get; set; }

    public DateTime? UpdateAt { get; set; }

    public DateTime? DeteleAt { get; set; }

    public double? Mark { get; set; }

    public virtual TlPaper Paper { get; set; } = null!;

    public virtual TlStudent Student { get; set; } = null!;

    public virtual ICollection<TlSubmitpaperDetail> TlSubmitpaperDetails { get; } = new List<TlSubmitpaperDetail>();
}
