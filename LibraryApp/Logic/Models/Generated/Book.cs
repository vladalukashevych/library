using System;
using System.Collections.Generic;

namespace Logic.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int GenreId { get; set; }

    public string? Description { get; set; }

    public string Publisher { get; set; } = null!;

    public short Year { get; set; }

    public bool IsRemoved { get; set; }

    public virtual Genre Genre { get; set; } = null!;

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();
}
