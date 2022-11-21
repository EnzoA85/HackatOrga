using System;
using System.Collections.Generic;

namespace OrgaHackat.Models
{
    public partial class Initiation
    {
        public Initiation()
        {
            Participants = new HashSet<Participant>();
        }

        public int Id { get; set; }
        public int? NbPlaceLimite { get; set; }

        public virtual Evenement IdNavigation { get; set; } = null!;
        public virtual ICollection<Participant> Participants { get; set; }
    }
}
