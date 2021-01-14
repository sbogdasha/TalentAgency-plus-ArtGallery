using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class ArtistActivity
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int ActivityId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
