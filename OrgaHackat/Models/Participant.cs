using System;
using System.Collections.Generic;

namespace OrgaHackat.Models
{
    public partial class Participant
    {
        public int Id { get; set; }
        public int? InitiationId { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string Mail { get; set; } = null!;

        public virtual Initiation? Initiation { get; set; }
    }
}
