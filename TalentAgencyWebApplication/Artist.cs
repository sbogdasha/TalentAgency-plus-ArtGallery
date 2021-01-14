using System;
using System.Collections.Generic;

#nullable disable

namespace TalentAgencyWebApplication
{
    public partial class Artist
    {
        public Artist()
        {
            ArtistActivities = new HashSet<ArtistActivity>();
            ArtistAwards = new HashSet<ArtistAward>();
            ArtistMedia = new HashSet<ArtistMedia>();
            ArtistProjects = new HashSet<ArtistProject>();
            Portfolios = new HashSet<Portfolio>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Biography { get; set; }
        public int GenderId { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual ICollection<ArtistActivity> ArtistActivities { get; set; }
        public virtual ICollection<ArtistAward> ArtistAwards { get; set; }
        public virtual ICollection<ArtistMedia> ArtistMedia { get; set; }
        public virtual ICollection<ArtistProject> ArtistProjects { get; set; }
        public virtual ICollection<Portfolio> Portfolios { get; set; }
    }
}
