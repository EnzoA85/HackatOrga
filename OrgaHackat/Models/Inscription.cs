using System;
using System.Collections.Generic;

namespace OrgaHackat.Models
{
    public partial class Inscription
    {
        public int Id { get; set; }
        public string TexteLibre { get; set; } = null!;
        public DateOnly DateInscription { get; set; }
        public int IdHackathon { get; set; }
        public int IdUtilisateur { get; set; }

        public virtual Hackathon IdHackathonNavigation { get; set; } = null!;
        public virtual Utilisateur IdUtilisateurNavigation { get; set; } = null!;
    }
}
