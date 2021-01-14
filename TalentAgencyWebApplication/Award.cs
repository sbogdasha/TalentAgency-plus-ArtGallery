using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class Award
    {
        public Award()
        {
            ArtistAwards = new HashSet<ArtistAward>();
        }

        public int Id { get; set; }
        public string Award1 { get; set; }

        public virtual ICollection<ArtistAward> ArtistAwards { get; set; }
    }
}
