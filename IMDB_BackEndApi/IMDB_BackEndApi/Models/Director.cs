using System;
using System.Collections.Generic;

namespace IMDB_BackEndApi.Models;

public partial class Director
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
