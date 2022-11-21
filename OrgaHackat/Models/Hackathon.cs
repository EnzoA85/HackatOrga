using System;
using System.Collections.Generic;

namespace OrgaHackat.Models
{
    public partial class Hackathon
    {
        public Hackathon()
        {
            Evenements = new HashSet<Evenement>();
            Inscriptions = new HashSet<Inscription>();
        }

        public int Id { get; set; }
        public DateOnly DateDebut { get; set; }
        public string? Lieu { get; set; }
        public string? Rue { get; set; }
        public string? Ville { get; set; }
        public string? CodePostal { get; set; }
        public string Theme { get; set; } = null!;
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int? NbPlaces { get; set; }
        public TimeOnly? HeureDebut { get; set; }
        public DateOnly? DateFin { get; set; }
        public TimeOnly? HeureFin { get; set; }
        public DateOnly? DateLimite { get; set; }

        public virtual ICollection<Evenement> Evenements { get; set; }
        public virtual ICollection<Inscription> Inscriptions { get; set; }
    }
}
