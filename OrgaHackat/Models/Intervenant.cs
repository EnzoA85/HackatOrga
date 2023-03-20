using System;
using System.Collections.Generic;

namespace OrgaHackat.Models
{
    public partial class Intervenant
    {
        public Intervenant()
        {
            Conferences = new HashSet<Conference>();
        }

        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string? Mail { get; set; }

        public virtual ICollection<Conference> Conferences { get; set; }
    }
}
