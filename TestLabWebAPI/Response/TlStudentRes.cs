using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Response;

public partial class TlStudentRes
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public DateTime? DeteleAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public byte[] CreateAt { get; set; } = null!;

    public virtual ICollection<TlSubmitpaperRes> TlSubmitpapers { get; } = new List<TlSubmitpaperRes>();

}
