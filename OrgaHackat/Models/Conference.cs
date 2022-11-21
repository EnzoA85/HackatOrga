using System;
using System.Collections.Generic;

namespace OrgaHackat.Models
{
    public partial class Conference
    {
        public int Id { get; set; }
        public string Theme { get; set; } = null!;

        public virtual Evenement IdNavigation { get; set; } = null!;
    }
}
