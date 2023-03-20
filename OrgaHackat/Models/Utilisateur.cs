using System;
using System.Collections.Generic;

namespace OrgaHackat.Models
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Inscriptions = new HashSet<Inscription>();
            Hackathons = new HashSet<Hackathon>();
        }

        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public DateOnly DateNaissance { get; set; }
        public string LienPortfolio { get; set; } = null!;
        public string Mdp { get; set; } = null!;
        public string Tel { get; set; } = null!;
        /// <summary>
        /// (DC2Type:json)
        /// </summary>
        public string? Roles { get; set; }

        public virtual ICollection<Inscription> Inscriptions { get; set; }

        public virtual ICollection<Hackathon> Hackathons { get; set; }
    }
}
