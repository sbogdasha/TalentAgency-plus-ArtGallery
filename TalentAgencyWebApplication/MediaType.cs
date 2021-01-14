using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class MediaType
    {
        public MediaType()
        {
            ArtistMedia = new HashSet<ArtistMedia>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ArtistMedia> ArtistMedia { get; set; }
    }
}
