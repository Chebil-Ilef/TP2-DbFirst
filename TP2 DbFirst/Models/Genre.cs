using System;
using System.Collections.Generic;

namespace TP2_DbFirst.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
