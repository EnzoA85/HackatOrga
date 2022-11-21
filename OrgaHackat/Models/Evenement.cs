using System;
using System.Collections.Generic;

namespace OrgaHackat.Models
{
    public partial class Evenement
    {
        public int Id { get; set; }
        public int HackathonId { get; set; }
        public string? Libelle { get; set; }
        public DateOnly? Date { get; set; }
        public int? Duree { get; set; }
        public TimeOnly? Heure { get; set; }
        public string? Salle { get; set; }
        public string Type { get; set; } = null!;

        public virtual Hackathon Hackathon { get; set; } = null!;
        public virtual Conference? Conference { get; set; }
        public virtual Initiation? Initiation { get; set; }
    }
}
