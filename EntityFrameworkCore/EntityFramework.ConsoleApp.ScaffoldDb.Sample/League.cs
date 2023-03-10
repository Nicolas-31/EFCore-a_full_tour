using System;
using System.Collections.Generic;

namespace EntityFramework.ConsoleApp.ScaffoldDb.Sample;

public partial class League
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Team> Teams { get; } = new List<Team>();
}
