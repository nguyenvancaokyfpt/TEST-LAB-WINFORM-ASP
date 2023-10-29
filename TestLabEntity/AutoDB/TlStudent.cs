using System;
using System.Collections.Generic;

namespace TestLabEntity.AutoDB;

public partial class TlStudent
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public virtual ICollection<TlSubmitpaper> TlSubmitpapers { get; } = new List<TlSubmitpaper>();

}
