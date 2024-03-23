using System;
using System.Collections.Generic;

namespace TestLabWebAPI.Models;

public partial class QuestsOfTest
{
    public int Id { get; set; }

    public int TestCode { get; set; }

    public int IdQuestion { get; set; }

    public DateTime? Timestamps { get; set; }

    public virtual Question IdQuestionNavigation { get; set; } = null!;

    public virtual Test TestCodeNavigation { get; set; } = null!;
}
