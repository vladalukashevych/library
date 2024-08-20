using System;
using System.Collections.Generic;

namespace Logic.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public DateTime JoiningDate { get; set; }

    public bool IsRemoved { get; set; }

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();
}
