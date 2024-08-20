using System;
using System.Collections.Generic;

namespace Logic.Models;

public partial class Record
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int BookId { get; set; }

    public DateTime Date { get; set; }

    public bool IsTaken { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
