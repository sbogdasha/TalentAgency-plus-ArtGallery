using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class ArtistAward
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int AwardId { get; set; }
        public DateTime Date { get; set; }
        public string Info { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Award Award { get; set; }
    }
}
